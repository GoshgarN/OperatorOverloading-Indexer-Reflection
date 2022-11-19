using OperatorOverloading_Indexer.Service;
using OperatorOverloading_Indexer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer.Controllers
{
    public class PersonController
    {
        public static void GetPersonDatas()
        {

            PersonService personService = new PersonService();

            var result = personService.GetFullData(m => m.Salary > 5000);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void GetFilteredPersonPowCount()
        {
            IPersonService personService = new PersonService();
            string word = "A";

            Console.WriteLine(personService.GetFilteredDataCount(m=>m.Name.ToLower().StartsWith(word.ToLower())));
        }
    }
}
