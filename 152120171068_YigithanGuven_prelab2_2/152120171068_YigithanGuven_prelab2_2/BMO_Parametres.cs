using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _152120171068_YigithanGuven_prelab2_2
{
    class BMO_Parametres
    {
        public BMO_Parametres() { }

        private double cityCoefficient = 0.0;
        private double experienceCoefficient = 0.0;
        private double managementCoefficient = 0.0;
        private double academicCoefficient = 0.0;
        private double languageCoefficient = 0.0;
        private double familyCoefficient = 0.0;
        private double salaryCoefficient = 0.0;
        private static double minimumSalary = 5000.0; //2020 yılı için belirlenen asgari brüt ücret.

        public double ExperienceCoefficient { get => experienceCoefficient; set => experienceCoefficient = value; }
        public double CityCoefficient1 { get => cityCoefficient; set => cityCoefficient = value; }
        public double ManagementCoefficient { get => managementCoefficient; set => managementCoefficient = value; }
        public double AcademicCoefficient { get => academicCoefficient; set => academicCoefficient = value; }
        public double LanguageCoefficient { get => languageCoefficient; set => languageCoefficient = value; }
        public double FamilyCoefficient { get => familyCoefficient; set => familyCoefficient = value; }
        public double MinimumSalary { get => salaryCoefficient; set => salaryCoefficient = value; }

        public void CalculateCityCoefficient(string city)
        {
            switch (city)
            {
                case "Adana":
                    cityCoefficient = 0.03;
                    break;
                case "Ankara":
                    cityCoefficient = 0.10;
                    break;
                case "Antalya":
                    cityCoefficient = 0.03;
                    break;
                case "Artvin":
                    cityCoefficient = 0.03;
                    break;
                case "Aydın":
                    cityCoefficient = 0.03;
                    break;
                case "Balıkesir":
                    cityCoefficient = 0.03;
                    break;
                case "Bilecik":
                    cityCoefficient = 0.03;
                    break;
                case "Bolu":
                    cityCoefficient = 0.05;
                    break;
                case "Burdur":
                    cityCoefficient = 0.03;
                    break;
                case "Bursa":
                    cityCoefficient = 0.03;
                    break;
                case "Çanakkale":
                    cityCoefficient = 0.03;
                    break;
                case "Denizli":
                    cityCoefficient = 0.03;
                    break;
                case "Edirne":
                    cityCoefficient = 0.05;
                    break;
                case "Eskişehir":
                    cityCoefficient = 0.03;
                    break;
                case "Giresun":
                    cityCoefficient = 0.03;
                    break;
                case "Gümüşhane":
                    cityCoefficient = 0.03;
                    break;
                case "Isparta":
                    cityCoefficient = 0.03;
                    break;
                case "Mersin":
                    cityCoefficient = 0.03;
                    break;
                case "İstanbul":
                    cityCoefficient = 0.15;
                    break;
                case "İzmir":
                    cityCoefficient = 0.10;
                    break;
                case "Kırklareli":
                    cityCoefficient = 0.05;
                    break;
                case "Kocaeli":
                    cityCoefficient = 0.05;
                    break;
                case "Muğla":
                    cityCoefficient = 0.03;
                    break;
                case "Ordu":
                    cityCoefficient = 0.03;
                    break;
                case "Rize":
                    cityCoefficient = 0.03;
                    break;
                case "Sakarya":
                    cityCoefficient = 0.05;
                    break;
                case "Tekirdağ":
                    cityCoefficient = 0.05;
                    break;
                case "Trabzon":
                    cityCoefficient = 0.03;
                    break;
                case "Yalova":
                    cityCoefficient = 0.05;
                    break;
                case "Düzce":
                    cityCoefficient = 0.05;
                    break;
                default:
                    cityCoefficient = 0.00;
                    break;
            }
        }
        public void CalculateExperienceCoefficient(int experience)
        {
            if (experience <= 20)
            {
                switch (experience)
                {
                    case 2:
                        experienceCoefficient = 0.60;
                        break;
                    case 3:
                        experienceCoefficient = 0.60;
                        break;
                    case 4:
                        experienceCoefficient = 0.60;
                        break;
                    case 5:
                        experienceCoefficient = 1.00;
                        break;
                    case 6:
                        experienceCoefficient = 1.00;
                        break;
                    case 7:
                        experienceCoefficient = 1.00;
                        break;
                    case 8:
                        experienceCoefficient = 1.00;
                        break;
                    case 9:
                        experienceCoefficient = 1.00;
                        break;
                    case 10:
                        experienceCoefficient = 1.20;
                        break;
                    case 11:
                        experienceCoefficient = 1.20;
                        break;
                    case 12:
                        experienceCoefficient = 1.20;
                        break;
                    case 13:
                        experienceCoefficient = 1.20;
                        break;
                    case 14:
                        experienceCoefficient = 1.20;
                        break;
                    case 15:
                        experienceCoefficient = 1.35;
                        break;
                    case 16:
                        experienceCoefficient = 1.35;
                        break;
                    case 17:
                        experienceCoefficient = 1.35;
                        break;
                    case 18:
                        experienceCoefficient = 1.35;
                        break;
                    case 19:
                        experienceCoefficient = 1.35;
                        break;
                    case 20:
                        experienceCoefficient = 1.35;
                        break;
                    default:
                        experienceCoefficient = 0.00;
                        break;
                }
            }
            else
            {
                experienceCoefficient = 1.50;
            }
        }
        public void CalculateManagementCoefficient(string management)
        {
            switch (management)
            {
                case "Team Leader / Group Manager / Technical Manager / Software Architect":
                    managementCoefficient = 0.50;
                    break;
                case "Project manager":
                    managementCoefficient = 0.75;
                    break;
                case "Director / Projects Manager":
                    managementCoefficient = 0.85;
                    break;
                case "CTO / General Manager":
                    managementCoefficient = 1.00;
                    break;
                case "IT Manager / Manager(If there is a maximum of 5 IT personnel in the IT department)":
                    managementCoefficient = 0.40;
                    break;
                case "IT Manager / Manager(If there are more than 5 IT personnel in the IT department)":
                    managementCoefficient = 0.60;
                    break;
                default:
                    managementCoefficient = 0.00;
                    break;
            }
        }
        public void CalculateAcademicCoefficient(string academic)
        {
            string[] Academic = academic.Split('.');
            academicCoefficient = 0.0;

            bool occupational_doc = false;
            bool occupational_yl = false;
            bool occupational_dr = false;
            bool nonoccupational_yl = false;
            bool nonoccupational_doc = false;

            if (Academic[0] == "Readership")
            {
                occupational_doc = true;
            }
            else if (Academic[0] == "Doctor's Degree")
            {
                occupational_dr = true;
            }
            else if (Academic[0] == "Master Degree")
            {
                occupational_yl = true;
            }
            else
            {
                occupational_doc = false;
                occupational_dr = false;
                occupational_yl = false;
            }

            if (Academic[1] == "Master Degree")
            {
                nonoccupational_yl = true;
            }
            else if (Academic[1] == "Doctor's Degree" || Academic[1] == "Readership")
            {
                nonoccupational_doc = true;
            }
            else
            {
                nonoccupational_doc = false;
                nonoccupational_yl = false;
            }

            if (occupational_doc == true)
            {
                academicCoefficient += 0.35;
            }
            if (occupational_dr == true && occupational_doc == false)
            {
                academicCoefficient += 0.30;
            }
            if (occupational_yl == true && occupational_dr == false && occupational_doc == false)
            {
                academicCoefficient += 0.10;
            }
            if (nonoccupational_doc == true && nonoccupational_yl == false)
            {
                academicCoefficient += 0.15;
            }
            if (nonoccupational_yl == true && nonoccupational_doc == false)
            {
                academicCoefficient += 0.05;
            }
            if (nonoccupational_yl == true && nonoccupational_doc == true)
            {
                academicCoefficient += 0.15;
            }
        }
        public void CalculatelanguageCoefficient(string language)
        {
            languageCoefficient = 0.0;
            string[] Language = language.Split('.');

            if (language == "Documented English Knowledge" || language== "English School Graduation")
            {
                languageCoefficient += 0.20;
            }

            if (Language[0] == "true")
            {
                languageCoefficient += 0.20;
                if (Convert.ToInt32(Language[1]) != 0)
                {
                    for (int i = 0; i < Convert.ToInt32(Language[1]); i++)
                    {
                        languageCoefficient += 0.05;
                    }
                }
            }
            else
            {
                if (Convert.ToInt32(Language[1]) != 0)
                {
                    for (int i = 0; i < Convert.ToInt32(Language[1]); i++)
                    {
                        languageCoefficient += 0.05;
                    }
                }
            }
        }
        public void FindChildrenAgeCoefficient(int age)
        {
            if (age <= 18)
            {
                switch (age)
                {
                    case 0:
                        familyCoefficient += 0.20;
                        break;
                    case 1:
                        familyCoefficient += 0.20;
                        break;
                    case 2:
                        familyCoefficient += 0.20;
                        break;
                    case 3:
                        familyCoefficient += 0.20;
                        break;
                    case 4:
                        familyCoefficient += 0.20;
                        break;
                    case 5:
                        familyCoefficient += 0.20;
                        break;
                    case 6:
                        familyCoefficient += 0.20;
                        break;
                    case 7:
                        familyCoefficient += 0.30;
                        break;
                    case 8:
                        familyCoefficient += 0.30;
                        break;
                    case 9:
                        familyCoefficient += 0.30;
                        break;
                    case 10:
                        familyCoefficient += 0.30;
                        break;
                    case 11:
                        familyCoefficient += 0.30;
                        break;
                    case 12:
                        familyCoefficient += 0.30;
                        break;
                    case 13:
                        familyCoefficient += 0.30;
                        break;
                    case 14:
                        familyCoefficient += 0.30;
                        break;
                    case 15:
                        familyCoefficient += 0.30;
                        break;
                    case 16:
                        familyCoefficient += 0.30;
                        break;
                    case 17:
                        familyCoefficient += 0.30;
                        break;
                    case 18:
                        familyCoefficient += 0.30;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                familyCoefficient += 0.40;
            }
        }
        public void CalculatefamilyCoefficient(string family, string children)
        {
            familyCoefficient = 0.0;

            if (family == "Wife/Husband not working")
            {
                familyCoefficient += 0.20;
            }
            if (children != "")
            {
                string[] Children = children.Split('.');

                if (Children.Length != 0)
                {
                    if (Children.Length <= 2)
                    {
                        for (int i = 0; i < Children.Length - 1; i++)
                        {
                            FindChildrenAgeCoefficient(Convert.ToInt32(Children[i]));
                        }
                    }
                    else
                    {
                        int maxAge1 = Convert.ToInt32(Children[0]);
                        int maxAge2 = Convert.ToInt32(Children[1]);
                        for (int i = 1; i < Children.Length - 1; i++)
                        {
                            if (Convert.ToInt32(Children[i]) > maxAge1)
                            {
                                maxAge2 = maxAge1;
                                maxAge1 = Convert.ToInt32(Children[i]);
                            }
                            else if (Convert.ToInt32(Children[i]) > maxAge2)
                            {
                                maxAge2 = Convert.ToInt32(Children[i]);
                            }
                        }
                        FindChildrenAgeCoefficient(maxAge1);
                        FindChildrenAgeCoefficient(maxAge2);
                    }
                }
            }
        }
        public double CalculateMinimumSalary(string city, int experience, string management, string academic, string language, string family, string children)
        {
            CalculateCityCoefficient(city);
            CalculateExperienceCoefficient(experience);
            CalculateManagementCoefficient(management);
            CalculateAcademicCoefficient(academic);
            CalculatelanguageCoefficient(language);
            CalculatefamilyCoefficient(family, children);
            salaryCoefficient += cityCoefficient + experienceCoefficient + managementCoefficient + academicCoefficient + languageCoefficient + familyCoefficient;

            return (minimumSalary * (salaryCoefficient + 1.00));
        }
    }
}
