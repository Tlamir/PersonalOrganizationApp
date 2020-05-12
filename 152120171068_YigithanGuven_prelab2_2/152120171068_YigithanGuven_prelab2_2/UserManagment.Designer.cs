namespace _152120171068_YigithanGuven_prelab2_2
{
    partial class UserManagment
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
            this.tB_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChangeUserType = new System.Windows.Forms.Button();
            this.rB_Admin = new System.Windows.Forms.RadioButton();
            this.rB_User = new System.Windows.Forms.RadioButton();
            this.rB_PartTimeUser = new System.Windows.Forms.RadioButton();
            this.btn_goBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tB_Username
            // 
            this.tB_Username.Location = new System.Drawing.Point(157, 80);
            this.tB_Username.Name = "tB_Username";
            this.tB_Username.Size = new System.Drawing.Size(100, 20);
            this.tB_Username.TabIndex = 1;
            this.tB_Username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // btn_ChangeUserType
            // 
            this.btn_ChangeUserType.Location = new System.Drawing.Point(148, 129);
            this.btn_ChangeUserType.Name = "btn_ChangeUserType";
            this.btn_ChangeUserType.Size = new System.Drawing.Size(109, 23);
            this.btn_ChangeUserType.TabIndex = 5;
            this.btn_ChangeUserType.Text = "Change User Type";
            this.btn_ChangeUserType.UseVisualStyleBackColor = true;
            this.btn_ChangeUserType.Click += new System.EventHandler(this.btn_ChangeUserType_Click);
            // 
            // rB_Admin
            // 
            this.rB_Admin.AutoSize = true;
            this.rB_Admin.Location = new System.Drawing.Point(79, 106);
            this.rB_Admin.Name = "rB_Admin";
            this.rB_Admin.Size = new System.Drawing.Size(54, 17);
            this.rB_Admin.TabIndex = 2;
            this.rB_Admin.TabStop = true;
            this.rB_Admin.Text = "Admin";
            this.rB_Admin.UseVisualStyleBackColor = true;
            // 
            // rB_User
            // 
            this.rB_User.AutoSize = true;
            this.rB_User.Location = new System.Drawing.Point(169, 106);
            this.rB_User.Name = "rB_User";
            this.rB_User.Size = new System.Drawing.Size(47, 17);
            this.rB_User.TabIndex = 3;
            this.rB_User.TabStop = true;
            this.rB_User.Text = "User";
            this.rB_User.UseVisualStyleBackColor = true;
            // 
            // rB_PartTimeUser
            // 
            this.rB_PartTimeUser.AutoSize = true;
            this.rB_PartTimeUser.Location = new System.Drawing.Point(260, 106);
            this.rB_PartTimeUser.Name = "rB_PartTimeUser";
            this.rB_PartTimeUser.Size = new System.Drawing.Size(95, 17);
            this.rB_PartTimeUser.TabIndex = 4;
            this.rB_PartTimeUser.TabStop = true;
            this.rB_PartTimeUser.Text = "Part Time User";
            this.rB_PartTimeUser.UseVisualStyleBackColor = true;
            // 
            // btn_goBack
            // 
            this.btn_goBack.Location = new System.Drawing.Point(12, 177);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(127, 23);
            this.btn_goBack.TabIndex = 6;
            this.btn_goBack.Text = "<---- Go Back To Menu";
            this.btn_goBack.UseVisualStyleBackColor = true;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "User Managment";
            // 
            // UserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(423, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_goBack);
            this.Controls.Add(this.rB_PartTimeUser);
            this.Controls.Add(this.rB_User);
            this.Controls.Add(this.rB_Admin);
            this.Controls.Add(this.btn_ChangeUserType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_Username);
            this.Name = "UserManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Organization App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserManagment_FormClosing);
            this.Load += new System.EventHandler(this.UserManagment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChangeUserType;
        private System.Windows.Forms.RadioButton rB_Admin;
        private System.Windows.Forms.RadioButton rB_User;
        private System.Windows.Forms.RadioButton rB_PartTimeUser;
        private System.Windows.Forms.Button btn_goBack;
        private System.Windows.Forms.Label label2;
    }
}