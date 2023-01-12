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

namespace Presentation.WriterView
{
    public partial class FormWriter : Form
    {


        Person SelectedPerson = null;
        Writer Model = null;
        Core.Data.LibraryContext Context = DataBase.Context;
        public FormWriter(Writer writer = null)
        {
            InitializeComponent();
            Model = writer;

        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            if (Model != null)
            {
                txt_bio.Text = Model.Biography;
                SelectedPerson = Model.Person;

                Lbl_SelectedPerson.Text = SelectedPerson.FirstName + " " + SelectedPerson.LastName;
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (SelectedPerson == null)
            {
                MyMessageBox.ValidationErrorMessage("لطفا شخصی را انتخاب نمایید");
                return;
            }

            if (Model == null)
            {
                Model = new Writer();
                Context.Add(Model);
            }
            Model.Person = SelectedPerson;
            Model.Biography = txt_bio.Text.Trim();

            Context.SaveChanges();
            MyMessageBox.SuccessMessage();

            Close();
        }

        private void selectPerson_Click(object sender, EventArgs e)
        {
            PersonView.FormPersonList form = new FormPersonList();
            form.ShowDialog();
            if (form.Model != null)
            {
                if(Context.Writers.Any(p=>p.Person.ID==form.Model.ID))
                {
                    MyMessageBox.ValidationErrorMessage(" این شخص به عنوان نویسنده قبلا تعریف شده است ");
                    return;
                }
                SelectedPerson = form.Model;
                Lbl_SelectedPerson.Text = SelectedPerson.FirstName + " " + SelectedPerson.LastName;
            }

        }
    }
}
