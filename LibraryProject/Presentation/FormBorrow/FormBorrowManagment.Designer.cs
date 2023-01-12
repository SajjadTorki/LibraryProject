
namespace Presentation.FormBorrow
{
    partial class FormBorrowManagment
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Lbl_SelectedPerson = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GridBorrow = new System.Windows.Forms.MyGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Combo_Subject = new System.Windows.Forms.MyComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Combo_Book = new System.Windows.Forms.MyComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picker_BorrowDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Numday = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBorrow)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.39706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.60294F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 544);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.Lbl_SelectedPerson);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(788, 54);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(697, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "انتخاب شخص:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(586, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "انتخاب عضو";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SelectPerson_Click);
            // 
            // Lbl_SelectedPerson
            // 
            this.Lbl_SelectedPerson.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_SelectedPerson.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_SelectedPerson.Location = new System.Drawing.Point(386, 5);
            this.Lbl_SelectedPerson.Name = "Lbl_SelectedPerson";
            this.Lbl_SelectedPerson.Size = new System.Drawing.Size(194, 42);
            this.Lbl_SelectedPerson.TabIndex = 5;
            this.Lbl_SelectedPerson.Text = "عضو انتخاب نشده";
            this.Lbl_SelectedPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.49622F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.50378F));
            this.tableLayoutPanel2.Controls.Add(this.GridBorrow, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 69);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 469);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // GridBorrow
            // 
            this.GridBorrow.AllowUserToAddRows = false;
            this.GridBorrow.AllowUserToDeleteRows = false;
            this.GridBorrow.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.GridBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColID,
            this.Column2,
            this.Column3});
            this.GridBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridBorrow.GridColor = System.Drawing.Color.BurlyWood;
            this.GridBorrow.Location = new System.Drawing.Point(394, 6);
            this.GridBorrow.Name = "GridBorrow";
            this.GridBorrow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridBorrow.RowTemplate.Height = 25;
            this.GridBorrow.Size = new System.Drawing.Size(388, 457);
            this.GridBorrow.TabIndex = 0;
            this.GridBorrow.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridBorrow_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BookName";
            this.Column1.HeaderText = "کتاب";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ID";
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BorrowDate";
            this.Column2.HeaderText = "تاریخ امانت";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NumberofDay";
            this.Column3.HeaderText = "تعداد روز";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.Combo_Subject);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.Combo_Book);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.picker_BorrowDate);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.txt_Numday);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(379, 457);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "موضوع:";
            // 
            // Combo_Subject
            // 
            this.Combo_Subject.DisplayMember = "Name";
            this.Combo_Subject.FormattingEnabled = true;
            this.Combo_Subject.Location = new System.Drawing.Point(167, 23);
            this.Combo_Subject.Name = "Combo_Subject";
            this.Combo_Subject.Size = new System.Drawing.Size(197, 23);
            this.Combo_Subject.TabIndex = 9;
            this.Combo_Subject.ValueMember = "ID";
            this.Combo_Subject.SelectionChangeCommitted += new System.EventHandler(this.Combo_Subject_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "کتاب :";
            // 
            // Combo_Book
            // 
            this.Combo_Book.DisplayMember = "Name";
            this.Combo_Book.FormattingEnabled = true;
            this.Combo_Book.Location = new System.Drawing.Point(167, 67);
            this.Combo_Book.Name = "Combo_Book";
            this.Combo_Book.Size = new System.Drawing.Size(197, 23);
            this.Combo_Book.TabIndex = 10;
            this.Combo_Book.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "تاریخ امانت:";
            // 
            // picker_BorrowDate
            // 
            this.picker_BorrowDate.Location = new System.Drawing.Point(167, 111);
            this.picker_BorrowDate.Name = "picker_BorrowDate";
            this.picker_BorrowDate.RightToLeftLayout = true;
            this.picker_BorrowDate.Size = new System.Drawing.Size(197, 23);
            this.picker_BorrowDate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "تعداد روز:";
            // 
            // txt_Numday
            // 
            this.txt_Numday.Location = new System.Drawing.Point(264, 155);
            this.txt_Numday.Name = "txt_Numday";
            this.txt_Numday.Size = new System.Drawing.Size(100, 23);
            this.txt_Numday.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(13, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 261);
            this.panel1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(70, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "ثبت جدید";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NewRegister_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(5, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(143, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Register_Click);
            // 
            // FormBorrowManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormBorrowManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBorrow";
            this.Load += new System.EventHandler(this.FormBorrow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridBorrow)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Lbl_SelectedPerson;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MyGridView GridBorrow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker picker_BorrowDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Numday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.MyComboBox Combo_Subject;
        private System.Windows.Forms.MyComboBox Combo_Book;
    }
}