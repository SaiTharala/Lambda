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
            AddingRecords(listPersonsInCity);
        }
        private static void AddingRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("111111", "TSP", "TL", 22));
            listPersonsInCity.Add(new Person("222222", "SPT", "AP", 55));
            listPersonsInCity.Add(new Person("333333", "SP", "BG", 66));
            listPersonsInCity.Add(new Person("444444", "TP", "US", 77));
        }
    }
}