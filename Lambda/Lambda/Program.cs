using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            AddRecords(listPersonsInCity);
            Retrieve_TopTwo_OfAgeAbove60(listPersonsInCity);
            Retrieve_Ages13To18(listPersonsInCity);
        }
        private static void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("111111", "TSP", "TL", 13));
            listPersonsInCity.Add(new Person("222222", "SPT", "AP", 80));
            listPersonsInCity.Add(new Person("333333", "SP", "BG", 15));
            listPersonsInCity.Add(new Person("444444", "TP", "US", 77));
        }
        private static void Retrieve_TopTwo_OfAgeAbove60(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: {0} Age: {1}", person.Name, person.Age);
            }
        }
        private static void Retrieve_Ages13To18(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age > 13 && e.Age < 19)).ToList())
            {
                Console.WriteLine("Name: {0} Age: {1}", person.Name, person.Age);
            }
        }
    }
}