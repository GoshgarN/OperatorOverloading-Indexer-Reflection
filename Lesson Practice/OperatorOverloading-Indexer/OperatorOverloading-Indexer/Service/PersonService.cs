using OperatorOverloading_Indexer.Models;
using OperatorOverloading_Indexer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer.Service
{
    public class PersonService : IPersonService
    {
        public int GetFilteredDataCount(Predicate<Person> predicate)
        {
            var datas = GetAll();

            var filteredDatas = datas.FindAll(predicate);

            var result = Math.Pow(filteredDatas.Count, 2);

            return (int)result;
        }

        public List<string> GetFullData(Predicate<Person> predicate)
        {

            var people = GetAll();

            var result = people.FindAll(predicate);

            return GetPersonDetails(result);

        }

        private List<Person> GetAll()
        {
            List<Person> people = new List<Person>();

            Person person1 = new Person()
            {
                Name = "Qoshqar",
                Surname = "Narimanli",
                Address = "Ahmadli",
                Salary = 10000

            };

            Person person2 = new Person()
            {
                Name = "Elon",
                Surname = "Musk",
                Address = "America",
                Salary = 7000

            };
            Person person3 = new Person()
            {
                Name = "Andrew",
                Surname = "Tate",
                Address = "Romain",
                Salary = 6000

            };
            Person person4 = new Person()
            {
                Name = "Sedat",
                Surname = "Peker",
                Address = "Istanbul",
                Salary = 3000

            };
            Person person5 = new Person()
            {
                Name = "Roman",
                Surname = "Abromovic",
                Address = "Moskow",
                Salary = 4500

            };

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);

            return people;

        }

        private List<string> GetPersonDetails(List<Person> people)
        {
            List<string> fullNDatas = new List<string>();

            foreach (var item in people)
            {
                string data = $"{item.Name} - {item.Surname} - {item.Address} - {item.Salary}";
                fullNDatas.Add(data);
            }

            return fullNDatas;
        }
    }
}
