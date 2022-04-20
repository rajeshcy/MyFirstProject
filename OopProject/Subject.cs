using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProject
{
   
    internal class Subject
    {
        private string name;
        private string code;
        private string teacher;
        private string grade;
        private string section;

        public string Name
        {
            get { return name; }
            set { name = value; }
        } 
      
        public string Code
        {
            get { return code; }
            set { code = value; }

        }
        public string Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public string Section
        {
            get { return section; }
            set { section = value; }
        }

    }
}
