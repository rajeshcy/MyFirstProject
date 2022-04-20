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
            List<Teacher> listteacher = new List<Teacher>();
            string teacherfile = "d:\\wipro\\.net\\teachers.txt";
            List<string> arrteacherclass = File.ReadAllLines(teacherfile).ToList();
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
            //string teacherfile = "d:\\wipro\\.net\\teachers.txt";
            //AddRecord("7", "Ishan", "Kishan", "8", "D",teacherfile);
            //AddRecord("6", "Rajesh", "Krishnan", "10", "C", teacherfile);
            //AddRecord("9", "Girish", "Karnad", "12", "A", teacherfile);

            //AddRecord("10", "awesome", "Patil", "6", "A", teacherfile);

            Display(listteacher);
            //SearchByID("2",listteacher);
            //SearchByFirstName("Girish", listteacher);
            //DeleteProfile("Krishnan",3,teacherfile);

            //UpdateRecord("Kishan",teacherfile,3, "2", "Awesome", "Patil", "50", "Z");
            SortByID(listteacher);
            SortByFirstName(listteacher);
            SortByLastName(listteacher);
            SortByClass(listteacher);
            SortBySection(listteacher);
        }
        public static void Display(List<Teacher> listteacher)
        {
            Console.WriteLine("Teacher Record without sorting :");
            Console.WriteLine();
            foreach (Teacher tea in listteacher)
                {
                    Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
                }
                Console.WriteLine();
        }

        public static void AddRecord(string ID, string FirstName, string LastName, string Cclass, string Section, string filepath)
        {

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    file.WriteLine(ID + "," + FirstName + "," + LastName + "," + Cclass + "," + Section);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Cannot add teacher new record", ex);
            }
        }

        public static void SearchByID(Object ob, List<Teacher> listteacher)
        {
            foreach (Teacher tea in listteacher)
            {
                bool v = tea.ID.Equals(ob);
                if (v == true)
                    Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
            }
            Console.WriteLine();  
        }

        public static void SearchByFirstName(Object ob, List<Teacher> listteacher)
        {
           
                foreach (Teacher tea in listteacher)
                {
                    bool v = tea.FirstName.Equals(ob);
                    if (v == true)
                        Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
                }
                Console.WriteLine();
                    
        }

        public static void DeleteProfile(string SearchTerm, int PositionOfSearchTerm, string filepath)
        {

            PositionOfSearchTerm--;
            string tempfile = "temp.txt";

            try
            {
                string[] lines = System.IO.File.ReadAllLines(@filepath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    bool v = fields[PositionOfSearchTerm].Equals(SearchTerm);

                    if (v == false)
                    {
                        AddRecord(fields[0], fields[1], fields[2], fields[3], fields[4], @tempfile);
                    }

                }
                File.Delete(@filepath);
                System.IO.File.Move(tempfile, filepath);


            }
            catch (Exception ex)
            {
                throw new Exception("Cannot delete file", ex);
            }

        }

        public static void UpdateRecord(string SearchTerm, string filepath, int PositionOfSearchTerm, string fieldOne, string fieldTwo, string fieldThree, string fieldFour, string fieldFive)
        {
            PositionOfSearchTerm--;
            string tempfile = "temp.txt";
            bool edited = false;
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@filepath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    bool v = fields[PositionOfSearchTerm].Equals(SearchTerm);

                    if (v == false)
                    {
                        AddRecord(fields[0], fields[1], fields[2], fields[3], fields[4], @tempfile);
                    }
                    else
                    {
                        if (!edited)
                        {
                            AddRecord(fieldOne, fieldTwo, fieldThree, fieldFour, fieldFive, @tempfile);
                            Console.WriteLine("Edited him");
                            edited = true;
                        }
                    }
                }
                File.Delete(@filepath);
                System.IO.File.Move(tempfile, filepath);
                Console.WriteLine("Record Edited");
            }
            catch (Exception ex)
            {
                Console.WriteLine("The program did work");
                throw new ApplicationException("Program did not work", ex);
            }
        }
        public static void SortByID(List<Teacher> listteacher)
        {
            
            SortByID sortbyid = new SortByID();
            listteacher.Sort(sortbyid);
            Console.WriteLine("Teacher Record sorted based on id is: ");
            Console.WriteLine();
            

            foreach (Teacher tea in listteacher)
            {
                Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
            }
            Console.WriteLine();

        }
        public static void SortByFirstName(List<Teacher> listteacher)
        {
            SortByFirstName sortbyfirstname = new SortByFirstName();
            listteacher.Sort(sortbyfirstname);
            Console.WriteLine("Teacher Record sorted based on First Name is: ");
            Console.WriteLine();

            foreach (Teacher tea in listteacher)
            {
                Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
            }
            Console.WriteLine();
        }
        public static void SortByLastName(List<Teacher> listteacher)
        {
            SortByLastName sortbylastname = new SortByLastName();
            listteacher.Sort(sortbylastname);
            Console.WriteLine("Teacher Record sorted based on Last Name is: ");
            Console.WriteLine();


            foreach (Teacher tea in listteacher)
            {
                Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
            }
            Console.WriteLine();
        }
        public static void SortByClass(List<Teacher> listteacher)
        {
            SortByCclass sortbyclass = new SortByCclass();
            listteacher.Sort(sortbyclass);
            Console.WriteLine("Teacher Record sorted based on Class is: ");
            Console.WriteLine();

            foreach (Teacher tea in listteacher)
            {
                Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
            }
            Console.WriteLine();
        }
        public static void SortBySection(List<Teacher> listteacher)
        {
            SortBySection sortbysection = new SortBySection();
            listteacher.Sort(sortbysection);
            Console.WriteLine("Teacher Record sorted based on Section is: ");
            Console.WriteLine();

            foreach (Teacher tea in listteacher)
            {
                Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
            }
            Console.WriteLine();
        }
    }
 }


    

