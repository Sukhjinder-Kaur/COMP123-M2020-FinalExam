using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*FileName: RaceAndClassForm.cs
Author's name: Sukhjinder Kaur
StudentID : 301087895 
Changes Made : updated the RaceRadioButton_CheckedChanged to make the radio selection button work
*/
namespace COMP123_M2020_FinalExam
{
    public partial class RaceAndClassForm : Form
    {
        public AbilityGeneratorForm previousForm;
        private string _selectedRace;


        public RaceAndClassForm()
        {
            InitializeComponent();
        }
    /// <summary>
    /// this method takes the user to the previous form and hides the current form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }
    /// <summary>
    /// This method selects the race when clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
          
           RadioButton selectedRace = (RadioButton)sender;

           this._selectedRace = selectedRace.Text;
          Character character = Program.character;
          character.Race = this._selectedRace;

    }
    /// <summary>
    /// This method takes the user to the Final form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
          FinalForm finalForm = new FinalForm
          {
          PreviousForm = this
            };

          finalForm.Show();
          this.Hide();
        }
    }
}
