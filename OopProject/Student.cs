using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProject
{
    internal class Student
    {
        private string name;
        private string grade;
        private string section;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        
        public string Section
        {
            get { return section; }
            set { section = value;  }
        }
      
    }
}
