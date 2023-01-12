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
using ViewModels.Shared;

namespace Presentation.MemberView
{
    public partial class FormMember : Form
    {


        Person SelectedPerson = null;
        Member Model = null;
        Core.Data.LibraryContext Context = DataBase.Context;
        public FormMember(Member member = null)
        {
            InitializeComponent();
            Model = member;

        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            ShowProofs();
            ShowMajors();
            if(Model!=null)
            {
                ShowRegisteredInformation();
            }
        }

        private void ShowRegisteredInformation()
        {
            SelectedPerson = Model.Person;
            Lbl_SelectedPerson.Text = SelectedPerson.FirstName + " " + SelectedPerson.LastName;
            date_MemberDate.Value = Model.MemberDate;
            Combo_Proof.SelectedValue = Model.ProofID;
            Combo_Major.SelectedValue = Model.MajorID;
        }

        private void ShowMajors()
        {
            Combo_Major.DataSource = Context.Majors.Select(p => new ComboBoxSearchModel
            {
                ID = p.ID,
                Name = p.MajorName
            }).ToList();

        }

        private void ShowProofs()
        {
            var _list = Context.Proofs.Select(p => new ComboBoxSearchModel
            {
                ID = p.ID,
                Name = p.ProofName
            }).ToList();

            Combo_Proof.DataSource = _list;

        }

        private void Register_Click(object sender, EventArgs e)
        {

            if (SelectedPerson == null)
            {
                MyMessageBox.ValidationErrorMessage(" لطفا شخصی را انتخاب کنید ");
                return;
            }
            if (Combo_Proof.SelectedIndex == -1)
            {
                MyMessageBox.ValidationErrorMessage(" لطفا اطلاعات باکس های ستاره دار را وارد نمایید ");
                return;
            }
            if (Model == null)
            {
                Model = new Member();
                Context.Add(Model);
            }
            Model.MajorID = Combo_Major.SelectedIndex == -1 ? -1 : Combo_Major.SelectedValue.ToInt();
            Model.ProofID = Combo_Proof.SelectedValue.ToInt();
            Model.Person = SelectedPerson;
            //Model.PersonID = SelectedPerson.ID;
            Model.MemberDate = date_MemberDate.Value;
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
                if (Context.Members.Any(p => p.Person.ID == form.Model.ID))
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
