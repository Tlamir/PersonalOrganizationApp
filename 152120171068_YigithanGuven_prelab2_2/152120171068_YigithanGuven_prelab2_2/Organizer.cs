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
    public partial class Organizer : Form
    {
        public Organizer()
        {
            InitializeComponent();
        }

        private void Organizer_Load(object sender, EventArgs e)
        {

        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu1 yeni = new Menu1();
            yeni.Show();
            this.Hide();
        }

        private void btncalendar_Click(object sender, EventArgs e)
        {
            FormCleander yeni = new FormCleander();
            yeni.Show();
            this.Hide();
        }

        private void btnphonebook_Click(object sender, EventArgs e)
        {
            FormPhoneBook yeni = new FormPhoneBook();
            yeni.Show();
            this.Hide();
        }

        private void btnnotes_Click(object sender, EventArgs e)
        {
            FormNotes yeni = new FormNotes();
            yeni.Show();
            this.Hide();
        }

        private void btnpersonalinformation_Click(object sender, EventArgs e)
        {
            Personalinformation yeni = new Personalinformation();
            yeni.Show();
            this.Hide();
        }

        private void btnsalarycal_Click(object sender, EventArgs e)
        {
            FormSalaryCalculator yeni = new FormSalaryCalculator();
            yeni.Show();
            this.Hide();
        }

        private void Organizer_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Application is Closing");
            System.Environment.Exit(0);
        }
    }
}
