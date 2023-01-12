
namespace Presentation.RoleView
{
    partial class FormRoleActivity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GridActivity = new System.Windows.Forms.MyGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.70516F));
            this.tableLayoutPanel1.Controls.Add(this.GridActivity, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(407, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GridActivity
            // 
            this.GridActivity.AllowUserToAddRows = false;
            this.GridActivity.AllowUserToDeleteRows = false;
            this.GridActivity.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.GridActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColID,
            this.ColSelected});
            this.GridActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridActivity.GridColor = System.Drawing.Color.White;
            this.GridActivity.Location = new System.Drawing.Point(3, 3);
            this.GridActivity.Name = "GridActivity";
            this.GridActivity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridActivity.RowTemplate.Height = 25;
            this.GridActivity.Size = new System.Drawing.Size(401, 554);
            this.GridActivity.TabIndex = 6;
            this.GridActivity.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridActivity_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ActivityDescription";
            this.Column1.HeaderText = "فعالیت";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ID";
            this.ColID.HeaderText = "آی دی";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColSelected
            // 
            this.ColSelected.DataPropertyName = "IsSelected";
            this.ColSelected.HeaderText = "انتخاب";
            this.ColSelected.Name = "ColSelected";
            // 
            // FormRoleActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "FormRoleActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تخصیص فعالیت ها";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRoleActivity_FormClosing);
            this.Load += new System.EventHandler(this.LoadForm);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridActivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MyGridView GridActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelected;
    }
}