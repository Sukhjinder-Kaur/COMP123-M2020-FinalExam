using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{/*FileName: Program.cs
Author's name: Sukhjinder Kaur
StudentID : 301087895 
Changes Made : Added objects of forms(GenerateName form and splash form) and program starts with splash form
*/
  public static class Program
  {
    public static SplashForm splashForm;
    public static GenerateNameForm generateNameForm;
    public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application which has object for all the forms
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashForm = new SplashForm();
            generateNameForm = new GenerateNameForm();
            Application.Run(splashForm);
        }
    }
}
