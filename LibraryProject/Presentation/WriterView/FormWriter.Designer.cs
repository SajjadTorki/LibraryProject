
namespace Presentation.WriterView
{
    partial class FormWriter
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
            this.txt_bio = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(99, 208);
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
            // txt_bio
            // 
            this.txt_bio.Location = new System.Drawing.Point(12, 88);
            this.txt_bio.Name = "txt_bio";
            this.txt_bio.Size = new System.Drawing.Size(469, 96);
            this.txt_bio.TabIndex = 3;
            this.txt_bio.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "بیوگرافی:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // FormWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 257);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_bio);
            this.Controls.Add(this.Lbl_SelectedPerson);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWriter";
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
        private System.Windows.Forms.RichTextBox txt_bio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}