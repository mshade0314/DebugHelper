using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DebugHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person> 
            { 
                new Person { Name = "aaa", Age = 10, Teachers = new List<Teacher>{new Teacher{TeacherName = "teacher1" }, new Teacher { TeacherName = "teacher2" } } }, 
                new Person { Name = "bbb", Age = 15 } 
            };
            var person = GetFirstPerson(persons);
            foreach (var p in persons)
            {
                Console.WriteLine(p.Name);
            }            
        }

        private static Person GetFirstPerson(List<Person> persons)
        {
            var person = persons.FirstOrDefault();
            return person;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
    public class Teacher
    {
        public string TeacherName { get; set; }
    }

}
