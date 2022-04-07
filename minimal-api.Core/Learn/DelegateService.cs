using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimal_api.Core.Learn
{
    public class DelegateService
    {
        public delegate bool FilterDelegate(Person person);

        public void DispalyPeople(List<Person> persons, FilterDelegate filterDelegate)
        {
            foreach (Person person in persons)
            {
                if (filterDelegate(person)) { Console.WriteLine(person.Name); }
            }
        }

        public bool IsOld(Person p) => p.Age > 50;
        public bool IsYoung(Person p) => p.Age < 10;
        public bool IsMale(Person p) => p.Type  == "Male";

        public void Print()
        {
            var people = new List<Person>() {
            new Person() { Name="A", Age=12 },
            new Person() { Name="B", Age=53 },
        };

            DispalyPeople(people, IsOld);
            DispalyPeople(people, IsMale);
            DispalyPeople(people, IsYoung);
            
        }
    }

    public class Person
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public string? Type { get; set; }
    }
}
