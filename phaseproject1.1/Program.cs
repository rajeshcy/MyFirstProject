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
            //string teacherfile = "d:\\wipro\\.net\\teachers.txt";
            //AddRecord("7", "Ishan", "Kishan", "8", "D",teacherfile);
            //AddRecord("6", "Rajesh", "Krishnan", "10", "C", teacherfile);
            //AddRecord("9", "Girish", "Karnad", "12", "A", teacherfile);

            //AddRecord("10", "awesome", "Patil", "6", "A", teacherfile);
            //Display();
            //SearchByID("100");
            //SearchByFirstName("Rajesh");
            //DeleteProfile("Krishnan",3,teacherfile);

            //UpdatRecord("Kishan",teacherfile,3, "2", "Awesome", "Patil", "50", "Z");
            SortByID();


        }
        public static void Display()
        {
            try
            {
                List<Teacher> listteacher = new List<Teacher>();
                string teacherfile = "d:\\wipro\\.net\\teachers.txt";

                List<string> arrteacherclass = File.ReadAllLines(teacherfile).ToList();
                Console.WriteLine("Teacher Record is: ");
                Console.WriteLine();
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
                foreach (Teacher tea in listteacher)
                {
                    Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Display the Record", ex);
            }
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

        public static void SearchByID(Object ob)
        {
            try
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
                foreach (Teacher tea in listteacher)
                {
                    bool v = tea.ID.Equals(ob);
                    if (v == true)
                        Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void SearchByFirstName(Object ob)
        {
            try
            {
                List<Teacher> listteacher = new List<Teacher>();

                string teacherfile = "D:\\wipro\\.net\\teachers.txt";

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
                foreach (Teacher tea in listteacher)
                {
                    bool v = tea.FirstName.Equals(ob);
                    if (v == true)
                        Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No such teacher is found", ex);
            }
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

        public static void UpdatRecord(string SearchTerm, string filepath, int PositionOfSearchTerm, string fieldOne, string fieldTwo, string fieldThree, string fieldFour, string fieldFive)
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
        public static void SortByID()
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
            listteacher.Sort();
            Console.WriteLine("Teacher Record sorted based on ID is: ");
            Console.WriteLine();
            

            foreach (Teacher tea in listteacher)
            {
                Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
            }
            Console.WriteLine();

        }
    }
 }


    

