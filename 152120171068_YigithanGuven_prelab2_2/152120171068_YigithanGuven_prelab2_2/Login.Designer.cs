using System;

namespace _152120171068_YigithanGuven_prelab2_2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLgn = new System.Windows.Forms.Button();
            this.tBpassword = new System.Windows.Forms.TextBox();
            this.tBname = new System.Windows.Forms.TextBox();
            this.Lblname = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lbFlag = new System.Windows.Forms.Label();
            this.Countdown = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.cB1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegisterCode = new System.Windows.Forms.Label();
            this.txtRegisterCode = new System.Windows.Forms.TextBox();
            this.lblVerificationCode = new System.Windows.Forms.Label();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLgn
            // 
            this.btnLgn.AccessibleName = "btnLgn";
            this.btnLgn.Location = new System.Drawing.Point(101, 176);
            this.btnLgn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLgn.Name = "btnLgn";
            this.btnLgn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLgn.Size = new System.Drawing.Size(76, 31);
            this.btnLgn.TabIndex = 4;
            this.btnLgn.Text = "Login";
            this.btnLgn.UseVisualStyleBackColor = true;
            this.btnLgn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBpassword
            // 
            this.tBpassword.AccessibleName = "tBpassword";
            this.tBpassword.Location = new System.Drawing.Point(143, 143);
            this.tBpassword.Margin = new System.Windows.Forms.Padding(2);
            this.tBpassword.Name = "tBpassword";
            this.tBpassword.Size = new System.Drawing.Size(78, 20);
            this.tBpassword.TabIndex = 3;
            this.tBpassword.UseSystemPasswordChar = true;
            // 
            // tBname
            // 
            this.tBname.AccessibleName = "tBname";
            this.tBname.Location = new System.Drawing.Point(144, 89);
            this.tBname.Margin = new System.Windows.Forms.Padding(2);
            this.tBname.Name = "tBname";
            this.tBname.Size = new System.Drawing.Size(76, 20);
            this.tBname.TabIndex = 1;
            // 
            // Lblname
            // 
            this.Lblname.AccessibleName = "Lblname";
            this.Lblname.AutoSize = true;
            this.Lblname.Location = new System.Drawing.Point(153, 73);
            this.Lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lblname.Name = "Lblname";
            this.Lblname.Size = new System.Drawing.Size(60, 13);
            this.Lblname.TabIndex = 3;
            this.Lblname.Text = "User Name";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(153, 119);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // lbFlag
            // 
            this.lbFlag.AutoSize = true;
            this.lbFlag.Location = new System.Drawing.Point(171, 242);
            this.lbFlag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFlag.Name = "lbFlag";
            this.lbFlag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbFlag.Size = new System.Drawing.Size(0, 13);
            this.lbFlag.TabIndex = 5;
            // 
            // Countdown
            // 
            this.Countdown.AutoSize = true;
            this.Countdown.Location = new System.Drawing.Point(141, 242);
            this.Countdown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(0, 13);
            this.Countdown.TabIndex = 6;
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(183, 176);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(76, 31);
            this.btnSignup.TabIndex = 5;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // cB1
            // 
            this.cB1.AutoSize = true;
            this.cB1.Location = new System.Drawing.Point(134, 213);
            this.cB1.Margin = new System.Windows.Forms.Padding(2);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(95, 17);
            this.cB1.TabIndex = 6;
            this.cB1.Text = "Remember Me";
            this.cB1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            // 
            // lblRegisterCode
            // 
            this.lblRegisterCode.AutoSize = true;
            this.lblRegisterCode.Location = new System.Drawing.Point(52, 317);
            this.lblRegisterCode.Name = "lblRegisterCode";
            this.lblRegisterCode.Size = new System.Drawing.Size(257, 13);
            this.lblRegisterCode.TabIndex = 16;
            this.lblRegisterCode.Text = "Enter Your Vertification Code And Press Login Button";
            this.lblRegisterCode.Visible = false;
            // 
            // txtRegisterCode
            // 
            this.txtRegisterCode.Location = new System.Drawing.Point(198, 290);
            this.txtRegisterCode.Name = "txtRegisterCode";
            this.txtRegisterCode.Size = new System.Drawing.Size(57, 20);
            this.txtRegisterCode.TabIndex = 15;
            this.txtRegisterCode.Visible = false;
            // 
            // lblVerificationCode
            // 
            this.lblVerificationCode.AutoSize = true;
            this.lblVerificationCode.Location = new System.Drawing.Point(102, 293);
            this.lblVerificationCode.Name = "lblVerificationCode";
            this.lblVerificationCode.Size = new System.Drawing.Size(90, 13);
            this.lblVerificationCode.TabIndex = 14;
            this.lblVerificationCode.Text = "Verification Code:";
            this.lblVerificationCode.Visible = false;
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.Location = new System.Drawing.Point(101, 258);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(154, 23);
            this.btnForgotPassword.TabIndex = 13;
            this.btnForgotPassword.Text = "Forgot Password";
            this.btnForgotPassword.UseVisualStyleBackColor = true;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(117, 242);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(138, 13);
            this.lblusername.TabIndex = 17;
            this.lblusername.Text = "Please enter your username";
            this.lblusername.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(377, 339);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblRegisterCode);
            this.Controls.Add(this.txtRegisterCode);
            this.Controls.Add(this.lblVerificationCode);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB1);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.lbFlag);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.Lblname);
            this.Controls.Add(this.tBname);
            this.Controls.Add(this.tBpassword);
            this.Controls.Add(this.btnLgn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Organization App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnLgn;
        private System.Windows.Forms.TextBox tBpassword;
        private System.Windows.Forms.Label Lblname;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lbFlag;
        private System.Windows.Forms.Label Countdown;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.CheckBox cB1;
        public System.Windows.Forms.TextBox tBname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegisterCode;
        private System.Windows.Forms.TextBox txtRegisterCode;
        private System.Windows.Forms.Label lblVerificationCode;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Label lblusername;
    }
}

