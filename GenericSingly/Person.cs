using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSingly
{
    internal class Person: IEquatable<Person>, IComparable<Person>
    {
        public string Name { get; set; }
        public string School { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{{ {Name}, {Age}}}");

            return sb.ToString();
        }

        public bool Equals(Person? other)
        {
            if (other != null && Name == other.Name && Age == other.Age)
            {
                return true;
            }
            return false;
        }

        public int CompareTo(Person? other)
        {
            if (other != null && Name == other.Name && Age == other.Age) return 0;
            
            if(Age > other.Age) return 1;

            if (Age < other.Age) return -1;

            return 0;
        }
    }
}
