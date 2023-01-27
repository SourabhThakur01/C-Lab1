using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string favouriteColour;
        private int age;
        private bool isWorking;

        public int PersonId { get => personId; set => personId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FavouriteColour { get => favouriteColour; set => favouriteColour = value; }
        public int Age { get => age; set => age = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public Person(int personId, string firstName, string lastName, int age, string favouriteColor, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favouriteColour = favouriteColor;
            this.age = age;
            this.isWorking = isWorking;
        }

        public override string ToString()
        {
            string formatted = "";

            formatted += "ID: " + PersonId + "\n";
            formatted += "FirstName: " + firstName + "\n";
            formatted += "LastName: " + lastName + "\n";
            formatted += "FavoriteColour: " + favouriteColour + "\n";
            formatted += "Age: " + age + "\n";
            formatted += "IsWorking: " + IsWorking;

            return formatted;
        }

        public string DisplayPersonInfo()
        {
            string formatted = "";

            formatted += personId+": "+firstName+" "+lastName + "'s " + "favorite colour is " + favouriteColour;

            return formatted;
        }

        public string ChangeFavoriteColour()
        {
            string formatted = "";

            formatted += personId + ": " + firstName + " " + lastName + "'s " + "favorite colour is " + "white";

            return formatted;
        }
        public string GetAgeInTenYears()
        {
            string formatted = "";

            age = age + 10;

            formatted += firstName + " " + lastName + "'s Age in 10 years is: " + age;

            age = age - 10;
            
            return formatted;
        }
    }


}
