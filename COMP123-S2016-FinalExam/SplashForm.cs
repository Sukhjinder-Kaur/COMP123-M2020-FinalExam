using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*FileName: SplashForm.cs
Author's name: Sukhjinder Kaur
StudentID : 301087895 
Changes Made :Added the splash form and the timer which makes form 
visible for 3 seconds and then move to next form
 */
namespace COMP123_M2020_FinalExam
{
  public partial class SplashForm : Form
  {
    public SplashForm()
    {
      InitializeComponent();
    }
    private void SpalshFormTimer_Tick(object sender, EventArgs e)
    {//shows the main form
      Program.generateNameForm.Show();
      //hides the splash screen
      this.Hide();
      //disables the timer
      SpalshFormTimer.Enabled = false;
    }
  }
}