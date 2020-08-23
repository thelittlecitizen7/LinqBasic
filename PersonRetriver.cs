using LinqBasic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqBasic
{
    public class PersonRetriver : IPersonRetriver
    {
        public PersonRetriver()
        {
            
        }
        public IEnumerable<int> GetMalesId(IEnumerable<Person> persons)
        {
            return persons.Where(p => p.PersonGender == Gender.Male).Select(p => p.Id);
        }

        public IEnumerable<Person> GetOddIds(IEnumerable<Person> persons)
        {
            return persons.Where(p => p.Id % 2 != 0);
        }

        public IEnumerable<Person> OrderById(IEnumerable<Person> persons)
        {
            return persons.OrderByDescending(p => p.Id);
        }
    }
}
