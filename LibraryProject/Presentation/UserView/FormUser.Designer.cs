
namespace Presentation.UserView
{
    partial class FormUser
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GridRoles = new System.Windows.Forms.MyGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRole = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.Lbl_SelectedPerson = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TabPerson = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRoles)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.TabPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GridRoles);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(563, 229);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "نقش ها";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridRoles
            // 
            this.GridRoles.AllowUserToAddRows = false;
            this.GridRoles.AllowUserToDeleteRows = false;
            this.GridRoles.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.GridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColID,
            this.ColRole});
            this.GridRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridRoles.GridColor = System.Drawing.Color.BurlyWood;
            this.GridRoles.Location = new System.Drawing.Point(3, 3);
            this.GridRoles.Name = "GridRoles";
            this.GridRoles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridRoles.RowTemplate.Height = 25;
            this.GridRoles.Size = new System.Drawing.Size(557, 223);
            this.GridRoles.TabIndex = 0;
            this.GridRoles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridRoles_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "RoleName";
            this.Column1.HeaderText = "نقش";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ID";
            this.ColID.HeaderText = "ColID";
            this.ColID.Name = "ColID";
            this.ColID.Visible = false;
            // 
            // ColRole
            // 
            this.ColRole.DataPropertyName = "IsSelected";
            this.ColRole.HeaderText = "نقش دارد؟";
            this.ColRole.Name = "ColRole";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_UserName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_Password);
            this.tabPage1.Controls.Add(this.Lbl_SelectedPerson);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(563, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اطلاعات کاربری";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(8, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "بازگشت";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(91, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 15;
            this.button4.Text = "تایید";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "کلمه کاربری:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(332, 63);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(126, 23);
            this.txt_UserName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "رمزعبور:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(332, 95);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(126, 23);
            this.txt_Password.TabIndex = 13;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // Lbl_SelectedPerson
            // 
            this.Lbl_SelectedPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_SelectedPerson.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_SelectedPerson.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_SelectedPerson.Location = new System.Drawing.Point(154, 20);
            this.Lbl_SelectedPerson.Name = "Lbl_SelectedPerson";
            this.Lbl_SelectedPerson.Size = new System.Drawing.Size(194, 27);
            this.Lbl_SelectedPerson.TabIndex = 2;
            this.Lbl_SelectedPerson.Text = "شخصی انتخاب نشده";
            this.Lbl_SelectedPerson.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "انتخاب شخص:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(354, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "انتخاب شخص";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.selectPerson_Click);
            // 
            // TabPerson
            // 
            this.TabPerson.Controls.Add(this.tabPage1);
            this.TabPerson.Controls.Add(this.tabPage2);
            this.TabPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPerson.Location = new System.Drawing.Point(0, 0);
            this.TabPerson.Name = "TabPerson";
            this.TabPerson.RightToLeftLayout = true;
            this.TabPerson.SelectedIndex = 0;
            this.TabPerson.Size = new System.Drawing.Size(571, 257);
            this.TabPerson.TabIndex = 18;
            this.TabPerson.SelectedIndexChanged += new System.EventHandler(this.TabPerson_SelectedIndexChanged);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 257);
            this.Controls.Add(this.TabPerson);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت شخص";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUser_FormClosing);
            this.Load += new System.EventHandler(this.FormBook_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridRoles)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabPerson.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MyGridView GridRoles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label Lbl_SelectedPerson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl TabPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColRole;
    }
}