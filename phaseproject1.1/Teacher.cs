using System;
using System.Collections.Generic;


namespace PhaseProject1
{
    internal class Teacher 
    {
        private string id;
        private string firstname;
        private string lastname;
        private string cclass;
        private string section;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Cclass
        {
            get { return cclass; }
            set { cclass = value; }
        }
        public string Section
        {
            get { return section; }
            set { section = value; }
        }
        
    }
}
