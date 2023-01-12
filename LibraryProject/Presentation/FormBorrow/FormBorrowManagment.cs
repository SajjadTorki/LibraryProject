using Core;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ViewModels.Book;

namespace Presentation.FormBorrow
{
    public partial class FormBorrowManagment : Form
    {
        Member selectedMember = null;
        Core.Data.LibraryContext Context = DataBase.Context;
        Domain.Entities.FormBorrow Model = null;
        public FormBorrowManagment()
        {
            InitializeComponent();
        }

        private void SelectPerson_Click(object sender, EventArgs e)
        {
            MemberView.FormMemberList form = new MemberView.FormMemberList();
            form.ShowDialog();
            if (form.Model != null)
            {
                selectedMember = form.Model;
                Lbl_SelectedPerson.Text = selectedMember.Person.FirstName + " " + selectedMember.Person.LastName;
                ShowBorrowListForSelectedMember();
                ClearText();
            }
        }

        private void ShowBorrowListForSelectedMember()
        {
            var _list = selectedMember.FormBorrows.
                Select(p => new ViewModels.FormBorrow.FormBorrowSearchModel
                {
                    ID = p.ID,
                    BookName = p.Book.BookName,
                    BorrowDate = p.BorrowDate,
                    NumberofDay = p.NumberofDay
                }).ToList();

            GridBorrow.DataSource = _list;
        }

        private void FormBorrow_Load(object sender, EventArgs e)
        {
            ShowSubject();
        }

        private void ShowSubject()
        {
            Combo_Subject.DataSource = Context.Subjects.Select(p => new
            ViewModels.Shared.ComboBoxSearchModel
            { ID = p.ID, Name = p.SubjectName }).ToList();
            Combo_Subject.SelectedIndex = -1;
        }

        private void Combo_Subject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowBooksForSelectedSubject();
        }

        private void ShowBooksForSelectedSubject()
        {
            int subecjtID = Combo_Subject.SelectedValue.ToInt();
            var _list = Context.Books.Where(p => p.SubjectId == subecjtID)
                .Select(p => new ViewModels.Shared.ComboBoxSearchModel { ID = p.ID, Name = p.BookName }).ToList();

            Combo_Book.DataSource = _list;
            Combo_Book.SelectedIndex = -1;
        }

        private void Register_Click(object sender, EventArgs e)
        {

            if (Combo_Book.SelectedIndex == -1 || txt_Numday.Text.Trim() == "" || txt_Numday.Text.Trim() == "0"
                || selectedMember == null)
            {
                MyMessageBox.ValidationErrorMessage(" اطلاعات اطلاعات ستاره دار را تکمیل نمایید ");
                return;
            }

            if (Model == null)
            {
                Model = new Domain.Entities.FormBorrow();
                Context.Add(Model);
            }
            Model.Member = selectedMember;
            Model.BookID = Combo_Book.SelectedValue.ToInt();

            Model.NumberofDay = txt_Numday.ToInt();
            Model.BorrowDate = picker_BorrowDate.Value;


            Context.SaveChanges();
            ShowBorrowListForSelectedMember();
            ClearText();
            MyMessageBox.SuccessMessage();


        }

        private void ClearText()
        {
            Combo_Subject.SelectedIndex = -1;
            Combo_Book.DataSource = null;
            txt_Numday.Text = "";
            picker_BorrowDate.Value = DateTime.Now;
            Model = null;
        }

        private void GridBorrow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = GridBorrow["ColID", e.RowIndex].Value.ToInt();
            Model = Context.FormBorrows.SingleOrDefault(p=>p.ID==id);
            if (Model != null)
            {
                Combo_Subject.SelectedValue = Model.Book.SubjectId;
                ShowBooksForSelectedSubject();
                Combo_Book.SelectedValue = Model.BookID;

                picker_BorrowDate.Value = Model.BorrowDate;
                txt_Numday.Text = Model.NumberofDay.ToString();
            }
        }


        private void NewRegister_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}
