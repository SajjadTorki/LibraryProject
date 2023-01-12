using Core;
using Domain.Entities;
using Presentation.BookView;
using Presentation.MajorView;
using Presentation.SubjectView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels.Subject;
using System.Security.Claims;

using System.Security.Cryptography;
using SecurityManager;

namespace Presentation.MenuView
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {



            InitializeComponent();
        }

        private void FormSubject_Click(object sender, EventArgs e)
        {
            AuthorizeManager.Authorize(UserActivity.SecurityManagment);
            FormSubject formSubject = new FormSubject();
            formSubject.ShowDialog();
        }

        private void FormMajor_Click(object sender, EventArgs e)
        {
            AuthorizeManager.Authorize(UserActivity.SecurityManagment);

            FormMajor formMajor = new FormMajor();
            formMajor.ShowDialog();
        }

        private void FormBook_Click(object sender, EventArgs e)
        {
            AuthorizeManager.Authorize(UserActivity.InformationManagment);

            FormBookList formBook = new FormBookList();
            formBook.ShowDialog();
        }
        private void FormPerson_Click(object sender, EventArgs e)
        {
            AuthorizeManager.Authorize(UserActivity.InformationManagment);

            PersonView.FormPersonList form = new PersonView.FormPersonList();
            form.ShowDialog();
        }

        private void FormListWriter_Click(object sender, EventArgs e)
        {
            AuthorizeManager.Authorize(UserActivity.InformationManagment);

            WriterView.FormWriterList form = new WriterView.FormWriterList();
            form.ShowDialog();
        }

        private void FormMember_Click(object sender, EventArgs e)
        {
            AuthorizeManager.Authorize(UserActivity.InformationManagment);

            Presentation.MemberView.FormMemberList form = new MemberView.FormMemberList();
            form.ShowDialog();
        }

        private void Formborrow_Click(object sender, EventArgs e)
        {
            AuthorizeManager.Authorize(UserActivity.BorrowManagment);

            Presentation.FormBorrow.FormBorrowManagment radForm1 = new Presentation.FormBorrow.FormBorrowManagment();
            radForm1.ShowDialog();
        }



        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormUser_Click(object sender, EventArgs e)
        {
            AuthorizeManager.Authorize(UserActivity.SecurityManagment);

            Presentation.UserView.FormUserList form = new UserView.FormUserList();
            form.ShowDialog();
        }

        private void FormRole_Click(object sender, EventArgs e)
        {
            AuthorizeManager.Authorize(UserActivity.SecurityManagment);

            Presentation.RoleView.FormRole form = new RoleView.FormRole();
            form.ShowDialog();
        }

        private void FormMenu_Shown(object sender, EventArgs e)
        {
            Presentation.UserView.FormLogin form = new UserView.FormLogin();
            form.ShowDialog();
            lbl_User.Text ="کاربر :"+
                SignInManager.OnlineUser.Person.FirstName + " " + SignInManager.OnlineUser.Person.LastName;
        }
    }
}