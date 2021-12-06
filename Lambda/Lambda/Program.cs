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
            Retrieve_TopTwo_Above60(listPersonsInCity);
        }
        private static void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("111111", "TSP", "TL", 22));
            listPersonsInCity.Add(new Person("222222", "SPT", "AP", 55));
            listPersonsInCity.Add(new Person("333333", "SP", "BG", 66));
            listPersonsInCity.Add(new Person("444444", "TP", "US", 77));
        }
        private static void Retrieve_TopTwo_Above60(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: {0} Age: {1}", person.Name, person.Age);
            }
        }
    }
}