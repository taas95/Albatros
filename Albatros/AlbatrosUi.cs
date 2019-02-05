using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albatros
{
    class AlbatrosUi
    {
        static System.Windows.Forms.Form secondForm = new System.Windows.Forms.Form();
        static System.Windows.Forms.Form lastForm = new System.Windows.Forms.Form();
        const int formCount = 3;
        static int currentFormCount=0;
        StringCollection formName = new StringCollection();
        //public static System.Windows.Forms.FormCollection OpenForms = new System.Windows.Forms.FormCollection();
        public void openChild(System.Windows.Forms.Form currentForm)
        {
            bool isFound = false;
            foreach(string name in formName)
            {
                if(name==currentForm.Name)
                {
                    isFound = true;
                }
            }
            if (isFound == false)
            {
                formName.Add(currentForm.Name);
                currentForm.Show();
            }
            else
            {
                //lastForm.Hide();
                currentForm.BringToFront();
                //lastForm = currentForm;

            }


            //if (currentFormCount < formCount)
            //{
            //    currentForm.Show();
            //    currentFormCount++;
            //    secondForm = currentForm;
               
            //    Console.WriteLine(currentFormCount.ToString());
            //}
            //else
            //{
            //    lastForm.Close();
            //    lastForm = secondForm;
            //    secondForm = currentForm;
            //    currentFormCount = currentFormCount - 1;
            //}






        }
        public int compTime(string oldtime, string newtime)
        {
            int newData = Convert.ToInt32(newtime);
            int oldData = Convert.ToInt32(oldtime);
            if((newData<oldData))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public string CheckTime(String time)
        {
            string timechecked="";

            int timeInInt = 0;
            try
            {
                timeInInt = Convert.ToInt32(time);
            }
            catch(Exception ex)
            {
                if (ex.Message == "Le format de la chaîne d'entrée est incorrect.")
                    Console.WriteLine("Entrez un format valide d'heure");
            }

            string timeConverted;
            if (timeInInt<=959 && timeInInt>0)
            {
                if (timeInInt <= 59)
                {
                timeConverted = "00" + timeInInt;
                    timechecked = timeConverted;
                }
                else
                {
                    //Check the time 

                    timeConverted = "0" + timeInInt;
                    if (Convert.ToInt16(timeConverted[1].ToString()) <= 9)
                    {
                        if (Convert.ToInt32(timeConverted[2].ToString()) <= 5)
                        {
                          timechecked = timeConverted;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid Minute " + timeConverted[2].ToString());
                            Console.WriteLine(timeConverted);

                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid Hour " + Convert.ToInt16(timeConverted[1].ToString().ToString()));
                        Console.WriteLine(timeConverted);

                    }

                }
            }
            else if (timeInInt > 959)
            {
                timeConverted = timeInInt.ToString();
                char hour = timeConverted[0];
                char min = timeConverted[2];
                if (Convert.ToInt32(hour.ToString()) <= 2)
                {
                    if (Convert.ToInt32(timeConverted[1].ToString()) <= 4)
                    {
                        if (Convert.ToInt32(min.ToString()) <= 5)
                        {
                            if (Convert.ToInt32(timeConverted[3].ToString()) <= 9)
                            {
                                Console.WriteLine("Temps valide");
                                timechecked = timeConverted;
                            }
                            else
                            {
                                Console.WriteLine("Minute invalide");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Minute invalide");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Heure invalide");
                    }

                }
                else
                {
                    Console.WriteLine("Heure invalide");
                }
            }


            return timechecked;
        }
        public string DatabaseTime(string time)
        {
            return time + "00";

        }
        //Gross WT 
        public int compareGrossWT(int val1, int val2)
        {
            if (val1 > val2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int checkGrossWT(int val1)
        {
            if (!(val1 > 500 && val1 < 800))
            {
                return 1;
            }
            else
            {
                return 0;

            }

        }
        public void checkG(Bunifu.Framework.UI.BunifuMaterialTextbox textbox)
        {
            int val = Convert.ToInt32(textbox.Text);
            if (!(val > 500 && val < 800))
                        {
                textbox.ForeColor = Color.Red;
                textbox.ForeColor = Color.Red;
            }
            else
            {
                textbox.ForeColor = Color.FromArgb(64, 64, 64);
                textbox.ForeColor = Color.FromArgb(64, 64, 64);
            }
            }
    }

    class AlbatrosUIColor
    {
        public static Color Dark = Color.FromArgb(64, 64, 64);
        public static Color LightPrimary = Color.FromArgb(255, 255, 255);
        public static Color DarkPrimary = Color.FromArgb(0, 0, 0);


    }
}
