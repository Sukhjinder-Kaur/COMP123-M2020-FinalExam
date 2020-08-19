using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*FileName: FinalForm.cs
Author's name: Sukhjinder Kaur
StudentID : 301087895 
Changes Made : Added FinalForm load event handler
*/

namespace COMP123_M2020_FinalExam
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm PreviousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }
    /// <summary>
    /// opens the about box when clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }
    /// <summary>
    /// This method takes to the RaceAndClassform and closes the Final form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.Show();
            this.Close();
        }
    /// <summary>
    /// This methods takes the user out the the form the application completely
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    /// <summary>
    /// FinalForm_Load event handler loads the textboxes values to the respective text boxes from program.character object
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FinalForm_Load(object sender, EventArgs e)
    {
      StrengthTextBox.Text = Program.character.Strength;
      DexterityTextBox.Text = Program.character.Dexterity;
      ConstitutionTextBox.Text = Program.character.Constitution;
      IntelligenceTextBox.Text = Program.character.Intelligence;
      WisdomTextBox.Text = Program.character.Wisdom;
      CharismaTextBox.Text = Program.character.Charisma;
      RaceTextBox.Text = Program.character.Race;
      FirstNameTestBox.Text = Program.character.FirstName;
      LastNameTextBox.Text = Program.character.LastName;
    }
  }
}
