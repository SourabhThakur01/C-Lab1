﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1,"Ian","Brooks",30,"Red",true);
            Person person2 = new Person(2, "Gina", "James", 18, "Green", false);
            Person person3 = new Person(3, "Mike", "Briscoe",45,"Blue",true);         
            Person person4 = new Person(4, "Mary", "Beals", 28, "Yellow", true);

            Console.WriteLine(person2.DisplayPersonInfo());
            Console.WriteLine(person3.ToString());
            Console.WriteLine(person1.ChangeFavoriteColour());
            Console.WriteLine(person4.GetAgeInTenYears());
            Console.WriteLine(person3.ToString());
            Console.WriteLine(person4.ToString());
            Console.WriteLine(person3.ToString());
            Console.ReadLine();
        }
    }
}
