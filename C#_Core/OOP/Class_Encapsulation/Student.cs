using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPresent
{
    public class Student
    {
        // fields
        private string name;

        // using accessors to get and
        // set the value of studentName
        // full properties
        public String Name
        {

            get { return name; }

            set { name = value; }
        }

        // Automatic properties
        public int Age { get; set; }

        public void Infor()
        {
            Console.WriteLine($"Name : {name} - Age {Age}");
        }
    }
}
