
namespace Presentation.MemberView
{
    partial class FormMember
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
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Lbl_SelectedPerson = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.date_MemberDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Combo_Proof = new System.Windows.Forms.MyComboBox();
            this.Combo_Major = new System.Windows.Forms.MyComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(91, 208);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 37);
            this.button8.TabIndex = 10;
            this.button8.Text = "تایید";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Register_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "انتخاب شخص:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(376, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "انتخاب شخص";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.selectPerson_Click);
            // 
            // Lbl_SelectedPerson
            // 
            this.Lbl_SelectedPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_SelectedPerson.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_SelectedPerson.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_SelectedPerson.Location = new System.Drawing.Point(176, 40);
            this.Lbl_SelectedPerson.Name = "Lbl_SelectedPerson";
            this.Lbl_SelectedPerson.Size = new System.Drawing.Size(194, 27);
            this.Lbl_SelectedPerson.TabIndex = 2;
            this.Lbl_SelectedPerson.Text = "شخصی انتخاب نشده";
            this.Lbl_SelectedPerson.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "بازگشت";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // date_MemberDate
            // 
            this.date_MemberDate.Location = new System.Drawing.Point(281, 102);
            this.date_MemberDate.Name = "date_MemberDate";
            this.date_MemberDate.Size = new System.Drawing.Size(200, 23);
            this.date_MemberDate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "تاریخ عضویت";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Combo_Proof
            // 
            this.Combo_Proof.DisplayMember = "Name";
            this.Combo_Proof.FormattingEnabled = true;
            this.Combo_Proof.Location = new System.Drawing.Point(360, 137);
            this.Combo_Proof.Name = "Combo_Proof";
            this.Combo_Proof.Size = new System.Drawing.Size(121, 23);
            this.Combo_Proof.TabIndex = 14;
            this.Combo_Proof.ValueMember = "ID";
            // 
            // Combo_Major
            // 
            this.Combo_Major.DisplayMember = "Name";
            this.Combo_Major.FormattingEnabled = true;
            this.Combo_Major.Location = new System.Drawing.Point(360, 169);
            this.Combo_Major.Name = "Combo_Major";
            this.Combo_Major.Size = new System.Drawing.Size(121, 23);
            this.Combo_Major.TabIndex = 15;
            this.Combo_Major.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "مقطع:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "رشته:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 257);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Combo_Major);
            this.Controls.Add(this.Combo_Proof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_MemberDate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Lbl_SelectedPerson);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMember";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت شخص";
            this.Load += new System.EventHandler(this.FormBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Lbl_SelectedPerson;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker date_MemberDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MyComboBox Combo_Proof;
        private System.Windows.Forms.MyComboBox Combo_Major;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}