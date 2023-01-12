using Core;
using Core.Data;
using Domain.Entities;
using Presentation.PersonView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ViewModels.Person;
using ViewModels.Writer;

namespace Presentation.WriterView
{
    public partial class FormWriterList : Form
    {

        LibraryContext Context = DataBase.Context;
        public Writer Model { get; set; }=null;
        public FormWriterList()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            FormWriter form = new FormWriter();
            form.ShowDialog();
            ShowWriters();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            ShowWriters();
        }

        private void ShowWriters()
        {

            string firstName = txt_FirstName.Text.Trim();
            string lastName = txt_LastName.Text.Trim();
            long nationalCode = txt_NationalCode.ToLong();

            var _list = Context.Writers.Where(p => p.Person.FirstName.Contains(firstName) && p.Person.LastName.Contains(lastName)
              && (p.Person.NationalCode == nationalCode || nationalCode == 0))
                .Select(writer => new WriterSearchModel { ID = writer.ID, FirstName = writer.Person.FirstName,
                    LastName = writer.Person.LastName, Biography=writer.Biography });

            GridWriter.DataSource = _list.ToList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }

            FormWriter form = new FormWriter(Model);
            form.ShowDialog();
            ShowWriters();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowWriters();
        }

        private void GridPerson_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = GridWriter["ColID", e.RowIndex].Value.ToInt();
            Model = Context.Writers.Find(id);
        }

        private void GridWriter_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = GridWriter["ColID", e.RowIndex].Value.ToInt();
            Model = Context.Writers.Find(id);
            Close();
        }
    }
}
