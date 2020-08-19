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
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }
    /// <summary>
    /// This method calls the GenerateNames() method which generates the random names
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GenerateButton_Click(object sender, EventArgs e)
    {
      GenerateNames();
    }
    /// <summary>
    /// This method takes to the next form and hides the current form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NextButton_Click(object sender, EventArgs e)
    {
      AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
      abilityGeneratorForm.Show();
      this.Hide();
    }
    /// <summary>
    /// GenerateNameForm Load event handles calls the GenerateNames()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GenerateNameForm_Load(object sender, EventArgs e)
    {
      GenerateNames();
    }
    /// <summary>
    /// Method will randomly pick First Names and Last Names from the list boxes
    /// </summary>
    private void GenerateNames()
    { //Instance of random Class
      var random = new Random();

      // Generating a random name from the listbox
      int firstNameIndex = random.Next(0, 50);
      int lastNameIndex = random.Next(0, 50);

      //Display the name to the  textbox
      FirstNameTextBox.Text = Convert.ToString(FirstNameListBox.Items[firstNameIndex]);
      LastNameTextBox.Text = Convert.ToString(LastNameListBox.Items[lastNameIndex]);

      //Assinging the random name genrated to the character object
      Program.character.FirstName = FirstNameTextBox.Text;
      Program.character.LastName = LastNameTextBox.Text;

    }
  }
}
