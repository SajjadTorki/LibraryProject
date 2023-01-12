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
using ViewModels.Activity;
using ViewModels.Subject;

namespace Presentation.RoleView
{
    public partial class FormRoleActivity : Form
    {
        LibraryContext Context = DataBase.Context;
       
        Role selectedRole = null;
        public FormRoleActivity(Role role)
        {
            InitializeComponent();
            selectedRole = role;
        }

        private void LoadForm(object sender, EventArgs e)
        {
            ShowActivities();
        }

        private void ShowActivities()
        {
            var _list = Context.Activities.Select(p => new ViewModels.Activity.ActivitySearchModel
            {
                ActivityDescription = p.ActivityDescription,
                ID = p.ID,
                IsSelected = selectedRole.Activities.Contains(p)
            }) ;



            GridActivity.DataSource = _list.ToList();
        }

        private void GridActivity_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2 || e.RowIndex==-1)
                return;

            int actid = GridActivity["ColID", e.RowIndex].Value.ToInt();
            var activity = Context.Activities.Find(actid);

            if(activity!=null)
            {
                if(Convert.ToBoolean(GridActivity[2,e.RowIndex].Value))
                {
                    selectedRole.Activities.Add(activity);
                }
                else
                {
                    selectedRole.Activities.Remove(activity);
                }

                Context.SaveChanges();
            }
        }

        private void FormRoleActivity_FormClosing(object sender, FormClosingEventArgs e)
        {
            GridActivity.EndEdit();
        }
    }
}
