namespace _152120171068_YigithanGuven_prelab2_2
{
    partial class FormSalaryCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalaryCalculator));
            this.cbManagement = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOccupationalAcademicDegree = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNonoccupationalAcademicDegree = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdSingle = new System.Windows.Forms.RadioButton();
            this.rdMarried = new System.Windows.Forms.RadioButton();
            this.cbNonWorking = new System.Windows.Forms.CheckBox();
            this.cbHasChild = new System.Windows.Forms.CheckBox();
            this.lbEnterChildAge = new System.Windows.Forms.Label();
            this.txtChildAge = new System.Windows.Forms.TextBox();
            this.cbStudying = new System.Windows.Forms.CheckBox();
            this.btnAddChildAge = new System.Windows.Forms.Button();
            this.lstChildrenAge = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFormalEnglish = new System.Windows.Forms.CheckBox();
            this.cbEnglishCollege = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lstOtherLanguages = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddLanguage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblMinSalary = new System.Windows.Forms.Label();
            this.txtMinSalary = new System.Windows.Forms.TextBox();
            this.BtnAddLanguage = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbManagement
            // 
            this.cbManagement.FormattingEnabled = true;
            this.cbManagement.Items.AddRange(new object[] {
            "Team Leader / Group Manager / Technical Manager / Software Architect",
            "Project manager",
            "Director / Projects Manager",
            "CTO / General Manager",
            "IT Manager / Manager (If there is a maximum of 5 IT personnel in the IT departmen" +
                "t)",
            "IT Manager / Manager (If there are more than 5 IT personnel in the IT department)" +
                "",
            "No"});
            this.cbManagement.Location = new System.Drawing.Point(200, 139);
            this.cbManagement.Name = "cbManagement";
            this.cbManagement.Size = new System.Drawing.Size(162, 21);
            this.cbManagement.TabIndex = 0;
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cbCity.Location = new System.Drawing.Point(200, 112);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(162, 21);
            this.cbCity.TabIndex = 1;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(200, 59);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(162, 20);
            this.TxtName.TabIndex = 2;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(200, 86);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(162, 20);
            this.TxtSurname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "City :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Management Task :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Years of Experience";
            // 
            // txtExperience
            // 
            this.txtExperience.Location = new System.Drawing.Point(200, 166);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(162, 20);
            this.txtExperience.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Professional Academic Degree :";
            // 
            // cbOccupationalAcademicDegree
            // 
            this.cbOccupationalAcademicDegree.FormattingEnabled = true;
            this.cbOccupationalAcademicDegree.Items.AddRange(new object[] {
            "Master Degree",
            "Doctor\'s Degree",
            "Readership",
            "No"});
            this.cbOccupationalAcademicDegree.Location = new System.Drawing.Point(200, 195);
            this.cbOccupationalAcademicDegree.Name = "cbOccupationalAcademicDegree";
            this.cbOccupationalAcademicDegree.Size = new System.Drawing.Size(162, 21);
            this.cbOccupationalAcademicDegree.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nonprofessional Academic Degree :";
            // 
            // cbNonoccupationalAcademicDegree
            // 
            this.cbNonoccupationalAcademicDegree.FormattingEnabled = true;
            this.cbNonoccupationalAcademicDegree.Items.AddRange(new object[] {
            "Master Degree",
            "Doctor\'s Degree",
            "Readership",
            "No"});
            this.cbNonoccupationalAcademicDegree.Location = new System.Drawing.Point(200, 223);
            this.cbNonoccupationalAcademicDegree.Name = "cbNonoccupationalAcademicDegree";
            this.cbNonoccupationalAcademicDegree.Size = new System.Drawing.Size(162, 21);
            this.cbNonoccupationalAcademicDegree.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Family Information :";
            // 
            // rdSingle
            // 
            this.rdSingle.AutoSize = true;
            this.rdSingle.Location = new System.Drawing.Point(27, 289);
            this.rdSingle.Name = "rdSingle";
            this.rdSingle.Size = new System.Drawing.Size(54, 17);
            this.rdSingle.TabIndex = 15;
            this.rdSingle.TabStop = true;
            this.rdSingle.Text = "Single";
            this.rdSingle.UseVisualStyleBackColor = true;
            // 
            // rdMarried
            // 
            this.rdMarried.AutoSize = true;
            this.rdMarried.Location = new System.Drawing.Point(87, 289);
            this.rdMarried.Name = "rdMarried";
            this.rdMarried.Size = new System.Drawing.Size(60, 17);
            this.rdMarried.TabIndex = 16;
            this.rdMarried.TabStop = true;
            this.rdMarried.Text = "Married";
            this.rdMarried.UseVisualStyleBackColor = true;
            this.rdMarried.Click += new System.EventHandler(this.rdMarried_Click);
            // 
            // cbNonWorking
            // 
            this.cbNonWorking.AutoSize = true;
            this.cbNonWorking.Location = new System.Drawing.Point(27, 317);
            this.cbNonWorking.Name = "cbNonWorking";
            this.cbNonWorking.Size = new System.Drawing.Size(154, 17);
            this.cbNonWorking.TabIndex = 17;
            this.cbNonWorking.Text = "Wife/Husband not working";
            this.cbNonWorking.UseVisualStyleBackColor = true;
            this.cbNonWorking.Visible = false;
            // 
            // cbHasChild
            // 
            this.cbHasChild.AutoSize = true;
            this.cbHasChild.Location = new System.Drawing.Point(27, 340);
            this.cbHasChild.Name = "cbHasChild";
            this.cbHasChild.Size = new System.Drawing.Size(73, 17);
            this.cbHasChild.TabIndex = 18;
            this.cbHasChild.Text = "I have kid";
            this.cbHasChild.UseVisualStyleBackColor = true;
            this.cbHasChild.CheckedChanged += new System.EventHandler(this.cbHasChild_CheckedChanged);
            // 
            // lbEnterChildAge
            // 
            this.lbEnterChildAge.AutoSize = true;
            this.lbEnterChildAge.Location = new System.Drawing.Point(27, 360);
            this.lbEnterChildAge.Name = "lbEnterChildAge";
            this.lbEnterChildAge.Size = new System.Drawing.Size(74, 13);
            this.lbEnterChildAge.TabIndex = 19;
            this.lbEnterChildAge.Text = "Add kids ages";
            this.lbEnterChildAge.Visible = false;
            // 
            // txtChildAge
            // 
            this.txtChildAge.Location = new System.Drawing.Point(27, 376);
            this.txtChildAge.Name = "txtChildAge";
            this.txtChildAge.Size = new System.Drawing.Size(71, 20);
            this.txtChildAge.TabIndex = 20;
            this.txtChildAge.Visible = false;
            // 
            // cbStudying
            // 
            this.cbStudying.AutoSize = true;
            this.cbStudying.Location = new System.Drawing.Point(112, 378);
            this.cbStudying.Name = "cbStudying";
            this.cbStudying.Size = new System.Drawing.Size(70, 17);
            this.cbStudying.TabIndex = 21;
            this.cbStudying.Text = "Studying ";
            this.cbStudying.UseVisualStyleBackColor = true;
            this.cbStudying.Visible = false;
            // 
            // btnAddChildAge
            // 
            this.btnAddChildAge.Location = new System.Drawing.Point(27, 402);
            this.btnAddChildAge.Name = "btnAddChildAge";
            this.btnAddChildAge.Size = new System.Drawing.Size(75, 23);
            this.btnAddChildAge.TabIndex = 22;
            this.btnAddChildAge.Text = "Add Ages";
            this.btnAddChildAge.UseVisualStyleBackColor = true;
            this.btnAddChildAge.Visible = false;
            this.btnAddChildAge.Click += new System.EventHandler(this.btnAddChildAge_Click);
            // 
            // lstChildrenAge
            // 
            this.lstChildrenAge.FormattingEnabled = true;
            this.lstChildrenAge.Location = new System.Drawing.Point(200, 376);
            this.lstChildrenAge.Name = "lstChildrenAge";
            this.lstChildrenAge.Size = new System.Drawing.Size(90, 69);
            this.lstChildrenAge.TabIndex = 23;
            this.lstChildrenAge.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(470, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Foreign Language Knowledge :";
            // 
            // cbFormalEnglish
            // 
            this.cbFormalEnglish.AutoSize = true;
            this.cbFormalEnglish.Location = new System.Drawing.Point(473, 88);
            this.cbFormalEnglish.Name = "cbFormalEnglish";
            this.cbFormalEnglish.Size = new System.Drawing.Size(180, 17);
            this.cbFormalEnglish.TabIndex = 25;
            this.cbFormalEnglish.Text = "Documented English Knowledge";
            this.cbFormalEnglish.UseVisualStyleBackColor = true;
            // 
            // cbEnglishCollege
            // 
            this.cbEnglishCollege.AutoSize = true;
            this.cbEnglishCollege.Location = new System.Drawing.Point(473, 115);
            this.cbEnglishCollege.Name = "cbEnglishCollege";
            this.cbEnglishCollege.Size = new System.Drawing.Size(151, 17);
            this.cbEnglishCollege.TabIndex = 26;
            this.cbEnglishCollege.Text = "English School Graduation";
            this.cbEnglishCollege.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(470, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Another Foreign Language :";
            // 
            // lstOtherLanguages
            // 
            this.lstOtherLanguages.FormattingEnabled = true;
            this.lstOtherLanguages.Location = new System.Drawing.Point(473, 206);
            this.lstOtherLanguages.Name = "lstOtherLanguages";
            this.lstOtherLanguages.Size = new System.Drawing.Size(177, 69);
            this.lstOtherLanguages.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(470, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Add Language :";
            // 
            // txtAddLanguage
            // 
            this.txtAddLanguage.Location = new System.Drawing.Point(559, 147);
            this.txtAddLanguage.Name = "txtAddLanguage";
            this.txtAddLanguage.Size = new System.Drawing.Size(100, 20);
            this.txtAddLanguage.TabIndex = 30;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(508, 289);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 49);
            this.btnCalculate.TabIndex = 31;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblMinSalary
            // 
            this.lblMinSalary.AutoSize = true;
            this.lblMinSalary.Location = new System.Drawing.Point(458, 405);
            this.lblMinSalary.Name = "lblMinSalary";
            this.lblMinSalary.Size = new System.Drawing.Size(86, 13);
            this.lblMinSalary.TabIndex = 32;
            this.lblMinSalary.Text = "Minimum Salary :";
            this.lblMinSalary.Visible = false;
            // 
            // txtMinSalary
            // 
            this.txtMinSalary.Location = new System.Drawing.Point(559, 402);
            this.txtMinSalary.Name = "txtMinSalary";
            this.txtMinSalary.Size = new System.Drawing.Size(100, 20);
            this.txtMinSalary.TabIndex = 33;
            this.txtMinSalary.Visible = false;
            // 
            // BtnAddLanguage
            // 
            this.BtnAddLanguage.Location = new System.Drawing.Point(665, 147);
            this.BtnAddLanguage.Name = "BtnAddLanguage";
            this.BtnAddLanguage.Size = new System.Drawing.Size(98, 23);
            this.BtnAddLanguage.TabIndex = 34;
            this.BtnAddLanguage.Text = "Add Language";
            this.BtnAddLanguage.UseVisualStyleBackColor = true;
            this.BtnAddLanguage.Click += new System.EventHandler(this.BtnAddLanguage_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 37);
            this.label9.TabIndex = 35;
            this.label9.Text = "Salary Calculator";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormSalaryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(773, 462);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnAddLanguage);
            this.Controls.Add(this.txtMinSalary);
            this.Controls.Add(this.lblMinSalary);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAddLanguage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lstOtherLanguages);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbEnglishCollege);
            this.Controls.Add(this.cbFormalEnglish);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstChildrenAge);
            this.Controls.Add(this.btnAddChildAge);
            this.Controls.Add(this.cbStudying);
            this.Controls.Add(this.txtChildAge);
            this.Controls.Add(this.lbEnterChildAge);
            this.Controls.Add(this.cbHasChild);
            this.Controls.Add(this.cbNonWorking);
            this.Controls.Add(this.rdMarried);
            this.Controls.Add(this.rdSingle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbNonoccupationalAcademicDegree);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbOccupationalAcademicDegree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.cbManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSalaryCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Organization App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSalaryCalculator_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbManagement;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOccupationalAcademicDegree;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbNonoccupationalAcademicDegree;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdSingle;
        private System.Windows.Forms.RadioButton rdMarried;
        private System.Windows.Forms.CheckBox cbNonWorking;
        private System.Windows.Forms.CheckBox cbHasChild;
        private System.Windows.Forms.Label lbEnterChildAge;
        private System.Windows.Forms.TextBox txtChildAge;
        private System.Windows.Forms.CheckBox cbStudying;
        private System.Windows.Forms.Button btnAddChildAge;
        private System.Windows.Forms.ListBox lstChildrenAge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbFormalEnglish;
        private System.Windows.Forms.CheckBox cbEnglishCollege;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstOtherLanguages;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAddLanguage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblMinSalary;
        private System.Windows.Forms.TextBox txtMinSalary;
        private System.Windows.Forms.Button BtnAddLanguage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}