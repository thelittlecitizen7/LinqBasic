using LinqBasic.Abstract;
using System;
using System.Collections.Generic;


namespace LinqBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Person> persons = new List<Person>()
            {
                new Person() { Id = 1, Name = "Tomer", PersonGender = Gender.Male},
                new Person(){Id = 2, Name = "Tami", PersonGender = Gender.Female},
                new Person(){Id = 3, Name = "Nadav", PersonGender = Gender.Male},
            };

            PersonRetriver personRetriver = new PersonRetriver();

            IEnumerable<int> malesIds = personRetriver.GetMalesId(persons);

            IEnumerable<Person> peronssOrderByIdDesc = personRetriver.OrderById(persons);

            IEnumerable<Person> personsWithOddId = personRetriver.GetOddIds(persons);

        }
    }
}
