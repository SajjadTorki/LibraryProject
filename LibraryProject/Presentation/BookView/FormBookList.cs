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

namespace Presentation.BookView
{
    public partial class FormBookList : Form
    {
        Book selectedBook = null;
        public FormBookList()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            FormBook form = new FormBook();
            form.ShowDialog();

            ShowBooks();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            ShowBooks();
            ShowSubjects();
        }

        private void ShowSubjects()
        {
            var _list = DataBase.Context.Subjects.Select(p => new ViewModels.Subject.SubjectSearchModel
            {
                ID = p.ID,
                SubjectName = p.SubjectName
            }).ToList();

            Combo_Subject.DataSource = _list;

            Combo_Subject.DisplayMember = "SubjectName";
            Combo_Subject.ValueMember = "ID";
            Combo_Subject.SelectedIndex = -1;
        }

        private void ShowBooks()
        {
            string bookName = txt_BookName.Text.Trim();
            string isbn = txt_ISBN.Text.Trim();
            int subjectId = Combo_Subject.SelectedValue.ToInt();

            var _list = DataBase.Context.Books
                .Where(p => p.BookName.Contains(bookName) && p.ISBN.Contains(isbn) &&
                (p.SubjectId == subjectId || subjectId == 0))
                .Select(p =>
                new
                {
                    BookName = p.BookName,
                    ISBN = p.ISBN,
                    ID = p.ID,
                    SubjectName = p.Subject.SubjectName ,
                    p.Writers
                }).ToList();



            List<BookSearchModel> books = new List<BookSearchModel>();

            foreach (var item in _list)
            {
                BookSearchModel book = new BookSearchModel
                {
                    BookName = item.BookName,
                    ID=item.ID,
                    ISBN=item.ISBN,
                    SubjectName=item.SubjectName
                };

                foreach (var writer in item.Writers)
                {
                    book.Writers +=  writer.Person.FirstName + " " + writer.Person.LastName +" - ";
                }

                books.Add(book);
            }
            GridBook.DataSource = books.ToList();

        }

        private void GridBook_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            int id = GridBook["ColID", e.RowIndex].Value.ToInt();
            selectedBook = DataBase.Context.Books.Find(id);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (selectedBook == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }

            FormBook form = new FormBook(selectedBook);
            form.ShowDialog();
            ShowBooks();
        }

        private void Search_Click(object sender, EventArgs e) => ShowBooks();
    }
}
