using Core;
using Core.Data;
using Domain.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ViewModels.Member;

namespace Presentation.UserView
{
    public partial class FormUserList : Form
    {

        LibraryContext Context = DataBase.Context;
        public User Model { get; set; } = null;
        public FormUserList()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            FormUser form = new FormUser();
            form.ShowDialog();
            ShowUsers();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void ShowUsers()
        {
            string userName = txt_UserName.Text.Trim();
            var _list = Context.Users.Where(p => p.UserName.Contains(userName)).Select(p => new ViewModels.User.UserSearchModel
            {
                ID=p.ID,
                UserName = p.UserName,
                FirstName = p.Person.FirstName,
                LastName = p.Person.LastName
            }).ToList();

            GridWriter.DataSource = _list;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }

            FormUser form = new FormUser(Model);
            form.ShowDialog();
            ShowUsers();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void GridPerson_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = GridWriter["ColID", e.RowIndex].Value.ToInt();
            Model = Context.Users.SingleOrDefault(p => p.ID == id);
        }

     
    }
}
