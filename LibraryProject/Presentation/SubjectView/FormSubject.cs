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

namespace Presentation.SubjectView
{
    public partial class FormSubject : Form
    {
        LibraryContext Context = DataBase.Context;

        Subject SelectedSubject = null;
        public FormSubject()
        {

            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txt_SubjectName.Text.Trim() == "")
            {
                MyMessageBox.ValidationErrorMessage();
                return;
            }

            if (SelectedSubject == null)
            {
                Subject subject = new Subject
                {
                    SubjectName = txt_SubjectName.Text.Trim()
                };


                Context.Add(subject);
            }
            else
            {
                SelectedSubject.SubjectName = txt_SubjectName.Text.Trim();
                Context.Update(SelectedSubject);
            }
            Context.SaveChanges();
            ShowSubjecs();
            ClearText();
            MyMessageBox.SuccessMessage();

        }

        private void ClearText()
        {
            txt_SubjectName.Text = "";
            txt_SubjectName.Focus();

            SelectedSubject = null;
        }

        private void FormSubject_Load(object sender, EventArgs e)
        {
            ShowSubjecs();
        }

        private void ShowSubjecs()
        {

            GridSubject.DataSource = Context.Subjects
                .Select(p => new SubjectSearchModel { SubjectName = p.SubjectName, ID = p.ID, BookCount = p.Books.Count }).ToList();

            if (GridSubject.RowCount != 0)
            {
                GridSubject.Rows[0].Selected = false;
            }
        }

        private void GridSubject_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = Convert.ToInt32(GridSubject["ColID", e.RowIndex].Value);

            SelectedSubject = Context.Subjects.Find(id);
            if (SelectedSubject != null)
            {
                txt_SubjectName.Text = SelectedSubject.SubjectName;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (SelectedSubject == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }
            if (!MyMessageBox.ConfirmedMessage())
                return;

            Context.Remove(SelectedSubject);
            Context.SaveChanges();

            ShowSubjecs();
            ClearText();

            MyMessageBox.SuccessMessage();
        }

        private void GridSubject_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = Convert.ToInt32(GridSubject["ColID", e.RowIndex].Value);

            SelectedSubject = Context.Subjects
                .SingleOrDefault(p => p.ID == id);

            if (SelectedSubject != null)
            {
                BookView.FormBookofSubject form = new BookView.FormBookofSubject(SelectedSubject);
                form.ShowDialog();
            }

        }
    }
}
