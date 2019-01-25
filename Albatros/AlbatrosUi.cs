using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
