using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120171068_YigithanGuven_prelab2_2
{
    public partial class FormSalaryCalculator : Form
    {
        public FormSalaryCalculator()
        {
            InitializeComponent();
        }

        public string city = "";
        public int experience = 0;
        public string management = "";
        public string academic = "";
        public int numberOfLanguages = 0;
        public string language = "";
        public string staffLanguage = "";
        public string family = "";
        public string children = "";

        private void user()
        {
            user user_new = new user
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                City = cbCity.SelectedItem.ToString(),
                Experience = txtExperience.Text,
                Management = cbManagement.SelectedItem.ToString(),
                Occupational_Academic = cbOccupationalAcademicDegree.SelectedItem.ToString(),
                Nonoccupational_Academic = cbNonoccupationalAcademicDegree.SelectedItem.ToString(),
                Language = staffLanguage,
                Family = family,
                Children = children,
                MinimumSalary = Convert.ToDouble(txtMinSalary.Text)
            };
        }

        private void FindBMO_Parameters()
        {
            BMO_Parametres bMO = new BMO_Parametres();
            city = cbCity.SelectedItem.ToString();
            experience = Convert.ToInt32(txtExperience.Text);
            management = cbManagement.SelectedItem.ToString();
            academic += cbOccupationalAcademicDegree.SelectedItem.ToString() + "." + cbNonoccupationalAcademicDegree.SelectedItem.ToString();

            if (lstOtherLanguages.Items.Count != 0)
            {
                for (int i = 0; i < lstOtherLanguages.Items.Count; i++)
                {
                    numberOfLanguages++;
                }
            }
            if (cbEnglishCollege.Checked == true || cbFormalEnglish.Checked == true)
            {
                language += "true" + "." + numberOfLanguages.ToString();
                staffLanguage += "Documented English Knowledge" + "." + "English School Graduation" + ".";
                if (lstOtherLanguages.Items.Count != 0)
                {
                    for (int i = 0; i < lstOtherLanguages.Items.Count; i++)
                    {
                        staffLanguage += lstOtherLanguages.Items[i] + ".";
                    }
                }
            }
            else if (cbEnglishCollege.Checked == false && cbFormalEnglish.Checked == false)
            {
                language += "false" + "." + numberOfLanguages.ToString();
                staffLanguage += "No Documented English Knowledge" + "." + "No English School Graduation" + ".";
                if (lstOtherLanguages.Items.Count != 0)
                {
                    for (int i = 0; i < lstOtherLanguages.Items.Count; i++)
                    {
                        staffLanguage += lstOtherLanguages.Items[i] + ".";
                    }
                }
            }
            else if (cbEnglishCollege.Checked == true && cbFormalEnglish.Checked == false)
            {
                language += "true" + "." + numberOfLanguages.ToString();
                staffLanguage += "No Documented English Knowledge" + "." + "English School Graduation" + ".";
                if (lstOtherLanguages.Items.Count != 0)
                {
                    for (int i = 0; i < lstOtherLanguages.Items.Count; i++)
                    {
                        staffLanguage += lstOtherLanguages.Items[i] + ".";
                    }
                }
            }
            else if (cbEnglishCollege.Checked == false && cbFormalEnglish.Checked == true)
            {
                language += "true" + "." + numberOfLanguages.ToString();
                staffLanguage += "Documented English Knowledge" + "." + "No English School Graduation" + ".";
                if (lstOtherLanguages.Items.Count != 0)
                {
                    for (int i = 0; i < lstOtherLanguages.Items.Count; i++)
                    {
                        staffLanguage += lstOtherLanguages.Items[i] + ".";
                    }
                }
            }
            if (cbNonWorking.Checked == true && rdMarried.Checked == true)
            {
                if (cbHasChild.Checked == true)
                {
                    if (lstChildrenAge.Items.Count != 0)
                    {
                        for (int i = 0; i < lstChildrenAge.Items.Count; i++)
                        {
                            children += lstChildrenAge.Items[i].ToString() + ".";
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Please enter kids ages", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    family += "Wife/Husband not working";
                }
                else if (cbHasChild.Checked == false)
                {
                    family += "Wife/Husband not working";

                }
            }
            else if (cbNonWorking.Checked == false && rdMarried.Checked == true)
            {
                if (cbHasChild.Checked == true)
                {
                    if (lstChildrenAge.Items.Count != 0)
                    {
                        for (int i = 0; i < lstChildrenAge.Items.Count; i++)
                        {
                            children += lstChildrenAge.Items[i].ToString() + ".";
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Please enter kids ages", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    family += "Wife/Husband working";
                }
                else if (cbHasChild.Checked == false)
                {
                    family += "Wife/Husband working";
                }
            }
            else if (rdSingle.Checked == true)
            {
                if (cbHasChild.Checked == true)
                {
                    if (lstChildrenAge.Items.Count != 0)
                    {
                        for (int i = 0; i < lstChildrenAge.Items.Count; i++)
                        {
                            children += lstChildrenAge.Items[i].ToString() + ".";
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Please enter kids ages", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    family += "Single";
                }
                else if (cbHasChild.Checked == false)
                {
                    family += "Single";
                }
            }
            txtMinSalary.Text = bMO.CalculateMinimumSalary(city, experience, management, academic, language, family, children).ToString();
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void TxtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }


        private void TxtExperience_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rdMarried_Click(object sender, EventArgs e)
        {
            cbNonWorking.Visible = true;
        }

        private void TxtAddLanguage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void TxtChildAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbHasChild_CheckedChanged(object sender, EventArgs e)
        {
            txtChildAge.Visible = true;
            cbStudying.Visible = true;
            lstChildrenAge.Visible = true;
            lbEnterChildAge.Visible = true;
            btnAddChildAge.Visible = true;
        }

        private void btnAddChildAge_Click(object sender, EventArgs e)
        {
            lstChildrenAge.Visible = true;
            if (cbStudying.Checked == true)
            {
                if (txtChildAge.Text != "")
                {
                    lstChildrenAge.Items.Add(txtChildAge.Text);
                }
            }
            else if( Convert.ToInt32(txtChildAge.Text) >= 18 && cbStudying.Checked == false)
            {
                DialogResult dialogResult = MessageBox.Show("Children over the age of 18 cannot be added to non-students!", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtChildAge.Text != "")
                {
                    cbStudying.Checked = true;
                    lstChildrenAge.Items.Add(txtChildAge.Text);
                }
            }
        }

        private void BtnAddLanguage_Click(object sender, EventArgs e)
        {
            if (txtAddLanguage.Text != "")
            {
                if (txtAddLanguage.Text != "İngilizce" && txtAddLanguage.Text != "ingilizce")
                {
                    lstOtherLanguages.Items.Add(txtAddLanguage.Text);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("You cannot add the English language!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Enter a valid language!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SeçiliOlanıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstChildrenAge.Items.Remove(lstChildrenAge.SelectedItem);
        }


        private void SeçiliDiliSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstOtherLanguages.Items.Remove(lstOtherLanguages.SelectedItem);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtExperience.Text!="" && TxtName.Text!=""&&TxtSurname.Text!=""&&cbCity.Text!=""&&cbManagement.Text!=""&cbNonoccupationalAcademicDegree.Text!=""&&cbOccupationalAcademicDegree.Text!="")
            {
                lblMinSalary.Visible = true;
                txtMinSalary.Visible = true;
                FindBMO_Parameters();
                user();
            }
            else
            {
                MessageBox.Show("Please Enter The Empty Fields");
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Organizer yeni = new Organizer();
            yeni.Show();
            this.Hide();
        }

        private void FormSalaryCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Application is Closing");
            System.Environment.Exit(0);
        }
    }
}
