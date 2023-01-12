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

namespace Presentation.BookView
{
    public partial class FormBook : Form
    {
        Book Model = null;
        public FormBook(Book book = null)
        {
            InitializeComponent();

            Model = book;
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            ShowSubjects();
            if (Model != null)
            {
                ShowBookInformation();
            }
        }

        private void ShowBookInformation()
        {
            txt_Abstract.Text = Model.Abstract;
            txt_BookName.Text = Model.BookName;
            txt_ISBN.Text = Model.ISBN;

            Combo_Subject.SelectedValue = Model.SubjectId;
        }

        private void ShowSubjects()
        {
            Combo_Subject.DataSource = DataBase.Context.Subjects.ToList();
            Combo_Subject.DisplayMember = "SubjectName";
            Combo_Subject.ValueMember = "ID";
            Combo_Subject.SelectedIndex = -1;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txt_BookName.Text.Trim() == "" || txt_ISBN.Text.Trim() == "" || Combo_Subject.SelectedIndex == -1)
            {
                MyMessageBox.ValidationErrorMessage();
                return;
            }
            if (Model == null)
            {
                Model = new Book();
                DataBase.Context.Add(Model);
            }

            // Edit
            Model.ISBN = txt_ISBN.Text.Trim();
            Model.SubjectId = Combo_Subject.SelectedValue.ToInt();
            Model.Abstract = txt_Abstract.Text.Trim();
            Model.BookName = txt_BookName.Text.Trim();

            DataBase.Context.SaveChanges();

            MyMessageBox.SuccessMessage();

            Close();
        }


        #region BookWriters






        #endregion
        private void SelectWriter_Click(object sender, EventArgs e)
        {
            WriterView.FormWriterList form = new WriterView.FormWriterList();
            form.ShowDialog();
            if(form.Model!=null && Model!=null)
            {
                Model.Writers.Add(form.Model);
                DataBase.Context.SaveChanges();
                ShowBookWriters();
                MyMessageBox.SuccessMessage("نویسنده اضافه شد");
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1 && Model == null)
            {
                MyMessageBox.ValidationErrorMessage("جهت ورود به این قسمت ابتدا باید اطلاعات را ثبت نمایید");
                tabControl1.SelectedIndex = 0;
                return;
            }
            ShowBookWriters();

        }

        private void ShowBookWriters()
        {
            var _list = Model.Writers.ToList().Select(p => new ViewModels.Writer.WriterSearchModel
            {
                Biography = p.Biography,
                FirstName = p.Person.FirstName,
                LastName = p.Person.LastName,
                ID = p.ID
            }).ToList();

            GridWiter.DataSource = _list;
        }

        private void GridWiter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if(e.ColumnIndex==0)
            {
                int id = GridWiter["ColID", e.RowIndex].Value.ToInt();
               var writer= Model.Writers.FirstOrDefault(p => p.ID == id);
                Model.Writers.Remove(writer);
                DataBase.Context.SaveChanges();
                ShowBookWriters();
                MyMessageBox.SuccessMessage();
            }    
        }
    }
}
