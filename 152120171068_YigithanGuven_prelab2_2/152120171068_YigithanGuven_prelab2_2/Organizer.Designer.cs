namespace _152120171068_YigithanGuven_prelab2_2
{
    partial class Organizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organizer));
            this.btnphonebook = new System.Windows.Forms.Button();
            this.btnnotes = new System.Windows.Forms.Button();
            this.btnpersonalinformation = new System.Windows.Forms.Button();
            this.btncalendar = new System.Windows.Forms.Button();
            this.btnsalarycal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnphonebook
            // 
            this.btnphonebook.Location = new System.Drawing.Point(66, 142);
            this.btnphonebook.Name = "btnphonebook";
            this.btnphonebook.Size = new System.Drawing.Size(112, 37);
            this.btnphonebook.TabIndex = 1;
            this.btnphonebook.Text = "PhoneBook";
            this.btnphonebook.UseVisualStyleBackColor = true;
            this.btnphonebook.Click += new System.EventHandler(this.btnphonebook_Click);
            // 
            // btnnotes
            // 
            this.btnnotes.Location = new System.Drawing.Point(66, 185);
            this.btnnotes.Name = "btnnotes";
            this.btnnotes.Size = new System.Drawing.Size(112, 34);
            this.btnnotes.TabIndex = 2;
            this.btnnotes.Text = "Notes";
            this.btnnotes.UseVisualStyleBackColor = true;
            this.btnnotes.Click += new System.EventHandler(this.btnnotes_Click);
            // 
            // btnpersonalinformation
            // 
            this.btnpersonalinformation.Location = new System.Drawing.Point(66, 102);
            this.btnpersonalinformation.Name = "btnpersonalinformation";
            this.btnpersonalinformation.Size = new System.Drawing.Size(112, 34);
            this.btnpersonalinformation.TabIndex = 0;
            this.btnpersonalinformation.Text = "Personal Information";
            this.btnpersonalinformation.UseVisualStyleBackColor = true;
            this.btnpersonalinformation.Click += new System.EventHandler(this.btnpersonalinformation_Click);
            // 
            // btncalendar
            // 
            this.btncalendar.Location = new System.Drawing.Point(66, 225);
            this.btncalendar.Name = "btncalendar";
            this.btncalendar.Size = new System.Drawing.Size(112, 34);
            this.btncalendar.TabIndex = 3;
            this.btncalendar.Text = "Calendar";
            this.btncalendar.UseVisualStyleBackColor = true;
            this.btncalendar.Click += new System.EventHandler(this.btncalendar_Click);
            // 
            // btnsalarycal
            // 
            this.btnsalarycal.Location = new System.Drawing.Point(66, 265);
            this.btnsalarycal.Name = "btnsalarycal";
            this.btnsalarycal.Size = new System.Drawing.Size(112, 34);
            this.btnsalarycal.TabIndex = 4;
            this.btnsalarycal.Text = "Salary Calculator";
            this.btnsalarycal.UseVisualStyleBackColor = true;
            this.btnsalarycal.Click += new System.EventHandler(this.btnsalarycal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Organizer";
            // 
            // Organizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(239, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsalarycal);
            this.Controls.Add(this.btncalendar);
            this.Controls.Add(this.btnpersonalinformation);
            this.Controls.Add(this.btnnotes);
            this.Controls.Add(this.btnphonebook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Organizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Organization App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Organizer_FormClosing);
            this.Load += new System.EventHandler(this.Organizer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnphonebook;
        private System.Windows.Forms.Button btnnotes;
        private System.Windows.Forms.Button btnpersonalinformation;
        private System.Windows.Forms.Button btncalendar;
        private System.Windows.Forms.Button btnsalarycal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}