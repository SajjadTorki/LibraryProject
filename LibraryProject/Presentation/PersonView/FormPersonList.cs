using Core;
using Core.Data;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ViewModels.Person;

namespace Presentation.PersonView
{
    public partial class FormPersonList : Form
    {

        LibraryContext Context = DataBase.Context;
        public Person Model { get; set; } = null;
        public FormPersonList()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Presentation.PersonView.FormPerson form = new FormPerson();
            form.ShowDialog();
        }

        private void LoadForm(object sender, EventArgs e) {
            ShowPeople();
        }

        private void ShowPeople()
        {
            string firstName = txt_FirstName.Text.Trim();
            string lastName = txt_LastName.Text.Trim();
            long nationalCode = txt_NationalCode.ToLong();

            var _list = Context.People.Where(p => p.FirstName.Contains(firstName) && p.LastName.Contains(lastName)
              && (p.NationalCode == nationalCode || nationalCode == 0))
                .Select(person => new PersonSearchModel {ID=person.ID,FirstName=person.FirstName,LastName=person.LastName,NationalCode=person.NationalCode });

            GridPerson.DataSource = _list.ToList();

        }


        private void Edit_Click(object sender, EventArgs e)
        {
            if(Model==null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }
          
                PersonView.FormPerson form = new FormPerson(Model);
                form.ShowDialog();
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowPeople();
        }

        private void GridPerson_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = GridPerson["ColID", e.RowIndex].Value.ToInt();
            Model = Context.People.Find(id);
           

        }

        private void GridPerson_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex == -1)
                return;

            int id = GridPerson["ColID", e.RowIndex].Value.ToInt();
            Model = Context.People.Find(id);
            Close();
        }
    }
}
