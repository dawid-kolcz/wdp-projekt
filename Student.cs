using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Student
    {
        public string name { get; private set; }
        public string lastname { get; private set; }

        public Student(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }
    }
}
