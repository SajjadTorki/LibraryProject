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
    public partial class FormBookofSubject : Form
    {
        Subject selectedSubject = null;
        public FormBookofSubject(Subject subject)
        {
            InitializeComponent();

            selectedSubject = subject;
        }

       
        private void LoadForm(object sender, EventArgs e)
        {
            ShowBooks();
        }

        private void ShowBooks()
        {
            Text = "کتاب های موضوع " + selectedSubject.SubjectName;
            GridBook.DataSource= selectedSubject.Books.ToList();
        }
    }
}
