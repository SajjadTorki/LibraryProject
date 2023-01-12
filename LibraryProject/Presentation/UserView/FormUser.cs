using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core;
using Domain.Entities;
using Presentation.PersonView;
using ViewModels.Shared;

namespace Presentation.UserView
{
    public partial class FormUser : Form
    {


        Person SelectedPerson = null;
        User Model = null;
        Core.Data.LibraryContext Context = DataBase.Context;
        public FormUser(User user = null)
        {
            InitializeComponent();
            Model = user;

        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            if (Model != null)
            {
                ShowRegisteredInformation();
            }
        }

        private void ShowRegisteredInformation()
        {
            SelectedPerson = Model.Person;
            Lbl_SelectedPerson.Text = SelectedPerson.FirstName + " " + SelectedPerson.LastName;
            txt_UserName.Text = Model.UserName;
        }




        private void selectPerson_Click(object sender, EventArgs e)
        {
            PersonView.FormPersonList form = new FormPersonList();
            form.ShowDialog();
            if (form.Model != null)
            {
                if (Context.Users.Any(p => p.Person.ID == form.Model.ID))
                {
                    MyMessageBox.ValidationErrorMessage(" این شخص به عنوان نویسنده قبلا تعریف شده است ");
                    return;
                }
                SelectedPerson = form.Model;
                Lbl_SelectedPerson.Text = SelectedPerson.FirstName + " " + SelectedPerson.LastName;
            }
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text.Trim() == "" || txt_UserName.Text.Trim() == "")
            {
                MyMessageBox.ValidationErrorMessage();
                return;
            }
            if (Model == null)
            {
                Model = new User();
                Context.Add(Model);
            }
            Model.Person = SelectedPerson;
            Model.Password = txt_Password.Text.Trim().Hash();
            Model.UserName = txt_UserName.Text.Trim();

            Context.SaveChanges();
            MyMessageBox.SuccessMessage();
        }

        private void TabPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabPerson.SelectedIndex == 1 && Model == null)
            {
                TabPerson.SelectedIndex = 0;
                MyMessageBox.ValidationErrorMessage(" کاربر ابتد باید ثبت بشود ");
                return;
            }

            ShowRoles();

        }

        private void ShowRoles()
        {
            var _list = Context.Roles.Select(p => new ViewModels.Role.RoleSearchModel
            {
                RoleName = p.RoleName,
                ID = p.ID,
                IsSelected=Model.Roles.Contains(p)
            }).ToList();

            GridRoles.DataSource = _list;
        }

        private void GridRoles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if(e.ColumnIndex==2)
            {
                int roleid = GridRoles["ColID", e.RowIndex].Value.ToInt();
               var role= Context.Roles.Find(roleid);

                if(Convert.ToBoolean(GridRoles[2,e.RowIndex].Value))
                {
                    Model.Roles.Add(role);
                }
                else
                {
                    Model.Roles.Remove(role);
                }

                Context.SaveChanges();
            }
        }

        private void FormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            GridRoles.EndEdit();
        }
    }
}
