using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*FileName: Character.cs
Author's name: Sukhjinder Kaur
StudentID : 301087895 
Changes Made : Added properties to the class which creates model for the person
*/
namespace COMP123_M2020_FinalExam
{
    public class Character
    {
        public string Strength { get; set; }

        public string Dexterity { get; set; }

        public string Constitution { get; set; }

        public string Intelligence { get; set; }

        public string Wisdom { get; set; }

        public string Charisma { get; set; }

        public string Race { get; set; }

    //Added new Properties First Name  and Last Name with getter and setter
        public string FirstName { get; set; }
        public string LastName { get; set; }
  }
}