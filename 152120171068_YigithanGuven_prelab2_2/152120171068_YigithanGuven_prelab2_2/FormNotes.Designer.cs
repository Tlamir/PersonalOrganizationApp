namespace _152120171068_YigithanGuven_prelab2_2
{
    partial class FormNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteNote = new System.Windows.Forms.Button();
            this.CreateNote = new System.Windows.Forms.Button();
            this.UpdateNote = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNoteName = new System.Windows.Forms.TextBox();
            this.Notes = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DeleteNote
            // 
            this.DeleteNote.Location = new System.Drawing.Point(343, 236);
            this.DeleteNote.Name = "DeleteNote";
            this.DeleteNote.Size = new System.Drawing.Size(79, 32);
            this.DeleteNote.TabIndex = 6;
            this.DeleteNote.Text = "Delete Note";
            this.DeleteNote.UseVisualStyleBackColor = true;
            this.DeleteNote.Click += new System.EventHandler(this.DeleteNote_Click);
            // 
            // CreateNote
            // 
            this.CreateNote.Location = new System.Drawing.Point(343, 82);
            this.CreateNote.Name = "CreateNote";
            this.CreateNote.Size = new System.Drawing.Size(79, 32);
            this.CreateNote.TabIndex = 3;
            this.CreateNote.Text = "Create Note";
            this.CreateNote.UseVisualStyleBackColor = true;
            this.CreateNote.Click += new System.EventHandler(this.CreateNote_Click);
            // 
            // UpdateNote
            // 
            this.UpdateNote.Location = new System.Drawing.Point(343, 120);
            this.UpdateNote.Name = "UpdateNote";
            this.UpdateNote.Size = new System.Drawing.Size(79, 32);
            this.UpdateNote.TabIndex = 5;
            this.UpdateNote.Text = "Update Note";
            this.UpdateNote.UseVisualStyleBackColor = true;
            this.UpdateNote.Click += new System.EventHandler(this.UpdateNote_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Note Name";
            // 
            // textBoxNoteName
            // 
            this.textBoxNoteName.Location = new System.Drawing.Point(210, 89);
            this.textBoxNoteName.Name = "textBoxNoteName";
            this.textBoxNoteName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNoteName.TabIndex = 2;
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Location = new System.Drawing.Point(80, 72);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(35, 13);
            this.Notes.TabIndex = 17;
            this.Notes.Text = "Notes";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(289, 148);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Note Name";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Note";
            this.columnHeader2.Width = 220;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 37);
            this.label2.TabIndex = 21;
            this.label2.Text = "Notes";
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.textBoxNoteName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.UpdateNote);
            this.Controls.Add(this.DeleteNote);
            this.Controls.Add(this.CreateNote);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Organization App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNotes_FormClosing);
            this.Load += new System.EventHandler(this.Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DeleteNote;
        private System.Windows.Forms.Button CreateNote;
        private System.Windows.Forms.Button UpdateNote;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNoteName;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
    }
}