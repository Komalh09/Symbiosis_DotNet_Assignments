using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_2
{
    internal class Person : IComparable<Person>
    {
        string Name { get; set; }
        int Age { get; set; }

        public Person(string n,int a)
        { 
            this.Name = n;
            this.Age = a;
        }
        public int CompareTo(Person ex) //use to compare only one data type.
        {
            if (this.Age >= ex.Age)
            {
                return 1;
            }
            else if (this.Age <= ex.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"\n Name: {Name} " + $" Age: {Age} ";
        }
         public void PrintDetails()
         {
             Console.WriteLine($"Name: {Name}, Age: {Age}");
         }
    }
    public class Program
    {
        public static void Main()
        {
            // Creating an array of 3 Persons
            Person[] persons = new Person[]
            {
            new Person("Sia", 22),
            new Person("Manav", 20),
            new Person("Riya", 25)
            };

            // Printing details before sorting
            Console.WriteLine("Before sorting:");
            foreach (var person in persons)
            {
                person.PrintDetails();
            }

            // Sorting the array
            Array.Sort(persons);

            // Printing details after sorting
            Console.WriteLine("\nAfter sorting:");
            foreach (var person in persons)
            {
                person.PrintDetails();
            }
        }
    }

}
