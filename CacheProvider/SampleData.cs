using System.Collections.Generic;
using System.Linq;

namespace CacheProvider
{
    public class SampleData
    {
        [CacheableResult(ExpireInMinutes = 300)]
        public IEnumerable<Person> GetPeople()
        {
            return GetAllPeople();
        }

        [CacheableResult(ExpireInMinutes = 300, Provider = "RedisCacheProvider")]
        public IEnumerable<Person> GetMen()
        {
            return GetAllPeople().Where(p => p.Sex == "M");
        }

        private IEnumerable<Person> GetAllPeople()
        {
            var people = new List<Person>();

            for (int i = 0; i < 1000; i++)
            {
                var p = new Person
                {
                    Name = "Person " + i,
                    Age = 45,
                    Sex = i % 2 == 1 ? "M" : "F"
                };

                people.Add(p);
            }

            return people;
        }

    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
}
