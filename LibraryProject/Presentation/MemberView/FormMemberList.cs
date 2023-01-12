using Core;
using Core.Data;
using Domain.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ViewModels.Member;

namespace Presentation.MemberView
{
    public partial class FormMemberList : Form
    {

        LibraryContext Context = DataBase.Context;
        public Member Model { get; set; }=null;
        public FormMemberList()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            FormMember form = new FormMember();
            form.ShowDialog();
            ShowMembers();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            pickerDate_FromMemberDate.Value = new DateTime(2011, 1, 1);
           
            ShowMembers();
        }

        private void ShowMembers()
        {

            string firstName = txt_FirstName.Text.Trim();
            string lastName = txt_LastName.Text.Trim();
            long nationalCode = txt_NationalCode.ToLong();

            DateTime fromDate =
                new DateTime(pickerDate_FromMemberDate.Value.Year,pickerDate_FromMemberDate.Value.Month,pickerDate_FromMemberDate.Value.Day,0,0,0);

            DateTime toDate= 
                new DateTime(pickerDate_ToMemberDate.Value.Year, pickerDate_ToMemberDate.Value.Month, pickerDate_ToMemberDate.Value.Day, 0, 0, 0);


            var _list = Context.Members.Where(p => p.Person.FirstName.Contains(firstName) && p.Person.LastName.Contains(lastName)
              && (p.Person.NationalCode == nationalCode || nationalCode == 0) &&
              
              (p.MemberDate.Date.CompareTo(fromDate)>=0) && (p.MemberDate.Date.CompareTo(toDate)<=0))
              
                
                .Select(member => new MemberSearchModel { ID = member.ID, FirstName = member.Person.FirstName,
                    LastName = member.Person.LastName, MemberDate=member.MemberDate,MajorName=member.Major.MajorName,ProofName=member.Proof.ProofName });

            GridWriter.DataSource = _list.ToList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                MyMessageBox.SelectionErrorMessage();
                return;
            }

            FormMember form = new FormMember(Model);
            form.ShowDialog();
            ShowMembers();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowMembers();
        }

        private void GridPerson_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = GridWriter["ColID", e.RowIndex].Value.ToInt();
            Model = Context.Members.SingleOrDefault(p=>p.ID==id);
        }

        private void GridWriter_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = GridWriter["ColID", e.RowIndex].Value.ToInt();
            Model = Context.Members.Find(id);
            Close();
        }
    }
}
