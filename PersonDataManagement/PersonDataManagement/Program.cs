using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC-1
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
            //Uc-2
            Retrieving_TopTwoRecord_ForAges_LessThanSixty(listPersonInCity);
            //UC-3
            ChekingForTeenagerPerson(listPersonInCity);
            //UC-4
            Retrieving_AverageOfAges(listPersonInCity);
            //UC-5
            Checking_Name_SAM(listPersonInCity);
            //UC-6
            Skip_Record(listPersonInCity);
            Console.ReadKey();
        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 15));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", 25));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));
        }
        //UC-2
        private static void Retrieving_TopTwoRecord_ForAges_LessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name:" + person.Name + "\tAge:  " + person.Age);
            }
        }
        //UC-3
        private static void ChekingForTeenagerPerson(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => e.Age >= 13 && e.Age <= 19))
            {
                Console.WriteLine("Yes,We have some teen-agers in the list");
            }
            else
                Console.WriteLine("No, we don't have teen-agers in the list");
        }
        //UC-4
        private static void Retrieving_AverageOfAges(List<Person> listPersonInCity)
        {
            double avg = listPersonInCity.Average(e => e.Age);
            Console.WriteLine("Average of Ages:  "+avg.ToString());
        }       
        //UC-5

        private static void Checking_Name_SAM(List<Person>listPersonInCity)
        {
           if( listPersonInCity.Exists(e => e.Name == "SAM")) 
            {
                Console.WriteLine("SAM exists in List...");
            }
            else
            {
                Console.WriteLine("SAM don't exists in List..");
            }
        }

        private static void Skip_Record(List<Person>listPersonInCity)
        {
            foreach(Person person in listPersonInCity.SkipWhile(e => e.Age<60))
            {
                Console.WriteLine("Name:" + person.Name + "\tAge:  " + person.Age);
            }
        }
    }
}
