using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120171068_YigithanGuven_prelab2_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static List<user> records = new List<user>();
        public static bool NoUser=true;

        [STAThread]
        static void Main()
        {
            // load recods from users csv file
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
                        Photo= csv.GetField("Photo")
                    };
                    NoUser = false;
                    Program.records.Add(record);                   
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
