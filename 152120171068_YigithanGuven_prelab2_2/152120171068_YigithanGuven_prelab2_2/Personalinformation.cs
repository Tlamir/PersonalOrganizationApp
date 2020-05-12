using CsvHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120171068_YigithanGuven_prelab2_2
{
    public partial class Personalinformation : Form
    {
        Stack undoStack = new Stack();
        Stack redoStack = new Stack();
        Stack undoStackstr = new Stack();
        Stack redoStackstr = new Stack();

        bool bundo=false;
        bool bredo=false;

        public Personalinformation()
        {
            InitializeComponent();
        }

        public List<user> recordsRexit = new List<user>();
        public List<user> records = new List<user>();

        public List<user> recordsPhoto = new List<user>();
        public List<user> recordsWrite = new List<user>();

        public List<user> recordsWritePhoto = new List<user>();
        public List<user> recordsWritePassword = new List<user>();

        Bitmap image;
        string base64Text;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //int flag = 0;
            string email = textBoxEmail.Text;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");   // email regex
            Match match = regex.Match(email);
            if (match.Success)
            {
                for (int i = 0; i < records.Count; i++)
                {
                    if(records[i].Username==Login.CurrentUser.Username)
                    {
                        var writeRecord = new user
                        {
                            Username = records[i].Username,
                            Password = records[i].Password,
                            UserType = records[i].UserType,
                            Name = textBoxName.Text,
                            Surname = textBoxSurname.Text,
                            Phonenumber = maskedTextBoxNumber.Text,
                            Address = tBadress.Text,
                            Email = textBoxEmail.Text,
                            Photo = records[i].Photo
                        };
                        recordsWrite.Add(writeRecord);
                    }
                    else
                        recordsWrite.Add(records[i]);
                }

                using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\users.csv")))
                using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv2.WriteRecords(recordsWrite);
                }

                MessageBox.Show("Successfully Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Enter Valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Personalinformation_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(Functions.bingPathToAppDir("\\data\\users.csv")))
            using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var record = new user
                    {
                        Username = csv.GetField("Username"),
                        Password = csv.GetField("Password"),
                        UserType = csv.GetField("UserType"),
                        Name = csv.GetField("Name"),
                        Surname = csv.GetField("Surname"),
                        Phonenumber = csv.GetField("Phonenumber"),
                        Address = csv.GetField("Address"),
                        Email = csv.GetField("Email"),
                        Photo = csv.GetField("Photo")
                    };
                    records.Add(record);
                }
            }

            for (int i = 0; i < records.Count; i++)
            {
                if (records[i].Username == Login.CurrentUser.Username)
                {
                    textBoxName.Text = records[i].Name;
                    textBoxSurname.Text = records[i].Surname;
                    maskedTextBoxNumber.Text = records[i].Phonenumber;
                    tBadress.Text = records[i].Address;
                    textBoxEmail.Text = records[i].Email;
                    base64Text = records[i].Photo;

                    byte[] imageBytes = Convert.FromBase64String(records[i].Photo);
                    // Convert byte[] to Image
                    using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                    {
                        pictureBox1.Image = Image.FromStream(ms, true);
                    }
                }
                Program.records[i] = records[i];
            }
            Clear();
            ClearUndo();
        }
        private void buttonPhoto_Click_1(object sender, EventArgs e)
        {
            string base64Text2 = "";

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG" +
            "|All files(*.*)|*.*";
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = (Image)image;

                byte[] imageArray = System.IO.File.ReadAllBytes(dialog.FileName);
                base64Text2 = Convert.ToBase64String(imageArray);
            }

            if (base64Text2 != "")
            {
                base64Text = base64Text2;
                MessageBox.Show("Photo Successfully Edited", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            for (int i = 0; i < records.Count; i++)
            {
                if (records[i].Username == Login.CurrentUser.Username)
                {
                    var writeRecord = new user
                    {
                        Username = records[i].Username,
                        Password = records[i].Password,
                        UserType = records[i].UserType,
                        Name = records[i].Name,
                        Surname = records[i].Surname,
                        Phonenumber = records[i].Phonenumber,
                        Address = records[i].Address,
                        Email = records[i].Email,
                        Photo = base64Text
                    };
                    recordsWritePhoto.Add(writeRecord);
                }
                else
                    recordsWritePhoto.Add(records[i]);
            }

            using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\users.csv")))
            using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv2.WriteRecords(recordsWritePhoto);
            }
        }
        public void Clear()
        {
            redoStackstr.Clear();
            redoStack.Clear();
        }     
        private void Personalinformation_KeyDown(object sender,KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Z && Control.ModifierKeys == Keys.Control && undoStack.Count > 0)
                {
                    bundo = true;
                    bredo = false;
                    string popped = undoStack.Pop().ToString();
                    redoStack.Push(popped);
                    if (popped == "1")
                    {
                        textBoxName.Text = undoStackstr.Pop().ToString();
                        textBoxName.Focus();
                        textBoxName.Select(textBoxName.Text.Length, 0);
                        redoStackstr.Push(Login.CurrentUser.Name);
                        Login.CurrentUser.Name = textBoxName.Text;                   
                    }
                    if (popped == "2")
                    {
                        textBoxSurname.Text = undoStackstr.Pop().ToString();
                        textBoxSurname.Focus();
                        textBoxSurname.Select(textBoxSurname.Text.Length, 0);
                        redoStackstr.Push(Login.CurrentUser.Surname);
                        Login.CurrentUser.Surname = textBoxSurname.Text;                      
                    }
                    if (popped == "3")
                    {
                        maskedTextBoxNumber.Text = undoStackstr.Pop().ToString();
                        maskedTextBoxNumber.Focus();
                        maskedTextBoxNumber.Select(maskedTextBoxNumber.Text.Length, 0);
                        redoStackstr.Push(Login.CurrentUser.Phonenumber);
                        Login.CurrentUser.Phonenumber = maskedTextBoxNumber.Text;                        
                    }
                    if (popped == "4")
                    {
                        tBadress.Text = undoStackstr.Pop().ToString();
                        tBadress.Focus();
                        tBadress.Select(tBadress.Text.Length, 0);
                        redoStackstr.Push(Login.CurrentUser.Address);
                        Login.CurrentUser.Address = tBadress.Text;                     
                    }
                    if (popped == "5")
                    {
                        textBoxEmail.Text = undoStackstr.Pop().ToString();
                        textBoxEmail.Focus();
                        textBoxEmail.Select(textBoxEmail.Text.Length, 0);
                        redoStackstr.Push(Login.CurrentUser.Email);
                        Login.CurrentUser.Email = textBoxEmail.Text;                      
                    }
                }
                else if (e.KeyCode == Keys.Y && Control.ModifierKeys == Keys.Control && redoStack.Count > 0)
                {
                    bundo = false;
                    bredo = true;
                    string popped = redoStack.Pop().ToString();
                    if (popped == "1")
                    {
                        textBoxName.Text = redoStackstr.Pop().ToString();
                        textBoxName.Focus();
                        textBoxName.Select(textBoxName.Text.Length, 0);
                    }
                    if (popped == "2")
                    {
                        textBoxSurname.Text = redoStackstr.Pop().ToString();
                        textBoxSurname.Focus();
                        textBoxSurname.Select(textBoxSurname.Text.Length, 0);
                    }
                    if (popped == "3")
                    {
                        maskedTextBoxNumber.Text = redoStackstr.Pop().ToString();
                        maskedTextBoxNumber.Focus();
                        maskedTextBoxNumber.Select(maskedTextBoxNumber.Text.Length, 0);
                    }
                    if (popped == "4")
                    {
                        tBadress.Text = redoStackstr.Pop().ToString();
                        tBadress.Focus();
                        tBadress.Select(tBadress.Text.Length, 0);
                    }
                    if (popped == "5")
                    {
                        textBoxEmail.Text = redoStackstr.Pop().ToString();
                        textBoxEmail.Focus();
                        textBoxEmail.Select(textBoxEmail.Text.Length, 0);
                    }
                }
                else
                {
                    bundo = false;
                    bredo = false;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Stack Is Empty");
            }
        }
        private void textBoxName_TextChanged_1(object sender, EventArgs e)
        {
            //here is the problem add ! in font 

            if (!String.IsNullOrWhiteSpace(textBoxName.Text)) // This will prevent exception when textbox is empty   
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxName.Text, "^[a-zA-ZğüşöçİĞÜŞÖÇ ]+$"))  // accepts letters and white space only
                {
                    MessageBox.Show("Enter Valid Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxName.Text.Remove(textBoxName.Text.Length - 1);
                    textBoxName.Clear();
                    textBoxName.Focus();
                }
            }

            if (!bundo)
            {
                undoStackstr.Push(Login.CurrentUser.Name);
                Login.CurrentUser.Name = textBoxName.Text;
                undoStack.Push("1");
                if (!bredo) { Clear(); }
            }
        }
        private void textBoxSurname_TextChanged_1(object sender, EventArgs e)
        {
            //here is the problem add ! in font 
            if (!String.IsNullOrWhiteSpace(textBoxSurname.Text)) // This will prevent exception when textbox is empty 
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxSurname.Text, "^[a-zA-ZğüşöçİĞÜŞÖÇ ]+$")) // accepts letters and white space only
                {
                    MessageBox.Show("Enter Valid Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxSurname.Text.Remove(textBoxSurname.Text.Length - 1);
                    textBoxSurname.Clear();
                    textBoxSurname.Focus();
                }
            }

            if (!bundo)
            {
                undoStackstr.Push(Login.CurrentUser.Surname);
                Login.CurrentUser.Surname = textBoxSurname.Text;
                undoStack.Push("2");
                if (!bredo) { Clear(); }
            }
        }
        private void TextBoxNumber_TextChanged(object sender, EventArgs e) 
        {
            if (!bundo)
            {
                undoStackstr.Push(Login.CurrentUser.Phonenumber);
                Login.CurrentUser.Phonenumber = maskedTextBoxNumber.Text;
                undoStack.Push("3");
                if (!bredo) { Clear(); }
            }
        }
        private void tBadress_TextChanged(object sender, EventArgs e)
        {
            if (!bundo)
            {
                undoStackstr.Push(Login.CurrentUser.Address);
                Login.CurrentUser.Address = tBadress.Text;
                undoStack.Push("4");
                if (!bredo) { Clear(); }
            }
        }
        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (!bundo)
            {
                undoStackstr.Push(Login.CurrentUser.Email);
                Login.CurrentUser.Email = textBoxEmail.Text;
                undoStack.Push("5");
                if (!bredo) { Clear(); }
            }
        }
        public void ClearUndo()
        {
            undoStackstr.Clear();
            undoStack.Clear();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Organizer yeni = new Organizer();
            yeni.Show();
            this.Hide();
        }
        private void buttonPassword_Click(object sender, EventArgs e)
        {
            if (tBpassword.Text.Length >= 8 && tBpassword.Text.Length <= 15)
            {
                MessageBox.Show("Password Successfully Changed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                for (int i = 0; i < records.Count; i++)
                {
                    if (records[i].Username == Login.CurrentUser.Username)
                    {
                        var writeRecord = new user
                        {
                            Username = records[i].Username,
                            Password = Functions.ComputeSha256Hash(tBpassword.Text),
                            UserType = records[i].UserType,
                            Name = records[i].Name,
                            Surname = records[i].Surname,
                            Phonenumber = records[i].Phonenumber,
                            Address = records[i].Address,
                            Email = records[i].Email,
                            Photo = records[i].Photo
                        };
                        recordsWritePassword.Add(writeRecord);
                    }
                    else
                        recordsWritePassword.Add(records[i]);
                }

                using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\users.csv")))
                using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv2.WriteRecords(recordsWritePassword);
                }

                String message = "Logging out";
                MessageBox.Show(message);

                // delete current remember me user
                using (var writer = new StreamWriter(Functions.bingPathToAppDir("\\data\\RememberMe.csv")))
                using (var csv2 = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv2.WriteRecords(recordsRexit);
                }
                System.Environment.Exit(0);
            }
            else
                MessageBox.Show("Password must be between 8 - 15 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Personalinformation_FormClosing(object sender, FormClosingEventArgs e)

        {
            MessageBox.Show("Application is Closing");
            System.Environment.Exit(0);
        }
    }
}
