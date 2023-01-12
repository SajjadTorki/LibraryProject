using Core;
using Core.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ViewModels.Subject;

namespace Presentation.RoleView
{
    public partial class FormRole : Form
    {
        LibraryContext Context = DataBase.Context;

        Role Model = null;
        public FormRole()
        {

            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txt_RoleName.Text.Trim() == "")
            {
                MyMessageBox.ValidationErrorMessage();
                return;
            }

            if (Model == null)
            {
                Model = new Role();

                Context.Add(Model);
            }

            Model.RoleName = txt_RoleName.Text.Trim();

            Context.SaveChanges();
            ShowRoles();
            ClearText();
            MyMessageBox.SuccessMessage();


        }

        private void ClearText()
        {
            txt_RoleName.Text = "";
            txt_RoleName.Focus();

            Model = null;
        }

        private void FormSubject_Load(object sender, EventArgs e)
        {
            ShowRoles();
        }

        private void ShowRoles()
        {

            GridRole.DataSource = Context.Roles.Where(p => p.ID != -1)
                .Select(p => new ViewModels.Role.RoleSearchModel { RoleName = p.RoleName, ID = p.ID }).ToList();

            if (GridRole.RowCount != 0)
            {
                GridRole.Rows[0].Selected = false;
            }
           
        }

        private void GridSubject_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = Convert.ToInt32(GridRole["ColID", e.RowIndex].Value);

            Model = Context.Roles.SingleOrDefault(p => p.ID == id);
            if (Model != null)
            {
                txt_RoleName.Text = Model.RoleName;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }
            if (!MyMessageBox.ConfirmedMessage())
                return;

            Context.Remove(Model);
            Context.SaveChanges();

            ShowRoles();
            ClearText();

            MyMessageBox.SuccessMessage();
        }

        private void GridRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = Convert.ToInt32(GridRole["ColID", e.RowIndex].Value);

            var role = Context.Roles.SingleOrDefault(p => p.ID == id);
            FormRoleActivity formRoleActivity = new FormRoleActivity(role);
            formRoleActivity.ShowDialog();
        }
    }
}
