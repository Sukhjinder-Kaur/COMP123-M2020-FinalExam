using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm PreviousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.Show();
            this.Close();
        }

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