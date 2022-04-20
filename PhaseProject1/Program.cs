using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a teacher Record File
            string teacherfile = "D:\\wipro\\.net\\teachers.txt";
  
            List<string> arrteacherclass = File.ReadAllLines(teacherfile).ToList();

            //Updating an existing record
            arrteacherclass.Add("1,Rajesh,Yandigeri,12,A");
            arrteacherclass.Add("4,Rohit,Sharma,11,B");

            List<Teacher> listteacher = new List<Teacher>();


            foreach (string line in arrteacherclass)
            { 
                string[] l = line.Split(',');
                Teacher teacherclass = new Teacher();
                teacherclass.ID = l[0];
                teacherclass.FirstName = l[1];
                teacherclass.LastName = l[2];
                teacherclass.Cclass = l[3];
                teacherclass.Section = l[4];
                listteacher.Add(teacherclass);

            }
            //Display all the records of all teachers without sorting 
            foreach (Teacher tea in listteacher)
            {
                Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
            }

            //Search a Record by ID
            foreach (Teacher tea in listteacher)
            {
                if (tea.ID == "10")
                    Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
            }


            //search a record by first name
            foreach (Teacher tea in listteacher)
            {
                if (tea.FirstName == "Rajesh")
                    Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
            }

            //search a record by last name
            foreach (Teacher tea in listteacher)
            {
                if (tea.LastName == "Dhoni")
                    Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
            }

            //search a record by class
            foreach (Teacher tea in listteacher)
            {
                if (tea.Cclass == "12")
                    Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
            }

            //search a record by section
            foreach (Teacher tea in listteacher)
            {
                if (tea.Section == "A")
                    Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
            }

            //Sorting teacher record
            foreach(Teacher tea in listteacher)
            {
               
            }
           
            

        }
    }
}
