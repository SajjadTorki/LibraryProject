using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core;
using Domain.Entities;
using System.IO;
using ViewModels.CommunicationType;

namespace Presentation.PersonView
{
    public partial class FormPerson : Form
    {

        Person Model = null;
        Core.Data.LibraryContext Context = DataBase.Context;
        public FormPerson(Person person=null)
        {
            InitializeComponent();
            Model = person;
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            if(Model!=null)
            {
                // Edit State
                ShowRegisteredInformation();
            }
        }

        private void ShowRegisteredInformation()
        {
            txt_FirstName.Text = Model.FirstName;
            txt_LastName.Text = Model.LastName;
            txt_NationalCode.Text = Model.NationalCode.ToString();

            if(Model.PersonPicture!=null && Model.PersonPicture.Picture!=null)
            {
                MemoryStream memory = new MemoryStream(Model.PersonPicture.Picture);

                PicPerson.Image = Image.FromStream(memory);
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                Model = new Person();
                Context.Add(Model);
            }
            else
            {
                Context.Update(Model);
            }

            Model.LastName = txt_LastName.Text.Trim();
            Model.NationalCode = txt_NationalCode.ToLong();
            Model.FirstName = txt_FirstName.Text.Trim();
            Context.SaveChanges();

            if(PicPerson.Image!=null)
            {
                MemoryStream memory = new MemoryStream();
                PicPerson.Image.Save(memory,ImageFormat.Jpeg);

                Model.PersonPicture = new PersonPicture();
                Model.PersonPicture.Picture = memory.GetBuffer();
                if(Model.PersonPicture.Picture.Length>20000)
                {
                    MyMessageBox.ValidationErrorMessage("اندازه عکس باید کمتر از 20 کیلو بایت باشد");
                    return;
                }
                Context.SaveChanges();
            }
            else
            {
                Model.PersonPicture = null;
                Context.SaveChanges();
            }

            MyMessageBox.SuccessMessage();
        }

        private void SelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (dialog.ShowDialog()==DialogResult.OK)
            {
                
                PicPerson.Image = Image.FromFile(dialog.FileName);
            }
        }

        #region Communication
        private void TabPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabPerson.SelectedIndex==1 && Model==null)
            {
                TabPerson.SelectedIndex = 0;
                MyMessageBox.ValidationErrorMessage(" شخص ابتد باید ثبت بشود ");
                return;
            }

            ShowCommunicationTypes();
            ShowCommunications();
        }

        private void ShowCommunicationTypes()
        {
            var _list= Context.CommunicationTypes.Select(p => new
             CommunicationTypeSearchModel
            { CommunicationTypeName = p.CommunicationTypeName, ID = p.ID }).ToList();

            Combo_CommunicationTypes.DataSource = _list;

            Combo_CommunicationTypes.ValueMember = "ID";
            Combo_CommunicationTypes.DisplayMember = "CommunicationTypeName";
            Combo_CommunicationTypes.SelectedIndex = -1;
        }
        private void AddCommunication_CLick(object sender, EventArgs e)
        {
            if(Combo_CommunicationTypes.SelectedIndex==-1 || txt_Value.Text.Trim()=="")
            {
                MyMessageBox.ValidationErrorMessage();
                return;
            }

            Model.Communications.Add(new Communication { 
              CommunicationTypeID=Combo_CommunicationTypes.SelectedValue.ToInt(),
              Value=txt_Value.Text.Trim()
            });

            Context.SaveChanges();
            MyMessageBox.SuccessMessage();
            ShowCommunications();
        }

        private void ShowCommunications()
        {
            var _list = Model.Communications.ToList().Select(p => new
            {
                p.CommunicationType.CommunicationTypeName,
                p.ID,
                p.Value
            }).ToList();


            // _list = Context.Communications.Where(p=>p.People.Any(k=>k.ID==Model.ID)).Select(p => new
            //{
            //    p.CommunicationType.CommunicationTypeName,
            //    p.ID,
            //    p.Value
            //}).ToList();


            GridCommunication.DataSource = _list;

        }
        #endregion


    }
}
