using System;
using System.Collections.Generic;
using System.IO;


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
            bool exitFlag = true;
            while (exitFlag)
            {
                Console.WriteLine();
                Console.WriteLine(
                    "Enter 1 to display unsorted teacher record\n" +
                    "Enter 2 to add teacher profile to teacher record\n" +
                    "Enter 3 to search teacher profile by ID\n" +
                    "Enter 4 to search teacher profile by First Name\n" +
                    "Enter 5 to update an existing teacher profile\n" +
                    "Enter 6 to sort teacher record by ID and display\n" +
                    "Enter 7 to sort teacher record by First Name and display\n" +
                    "Enter 8 to sort teacher record by Last Name and display\n" +
                    "Enter 9 to sort teacher record by class and display\n" +
                    "Enter 10 to sort record by Section and display\n" +
                    "Enter 11 to delete teacher profile from teacher record\n" +
                    "Enter 12 to EXIT");
                Console.Write("Enter operation number: ");
                int number = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                switch (number)
                {
                    case 1:
                        Display(listteacher);
                        break;
                    case 2:
                        Console.Write("Enter ID (integer) : ");
                        string id = Console.ReadLine();
                        Console.Write("Enter First Name: ");
                        string firstname = Console.ReadLine();
                        Console.Write("Enter Last Name: ");
                        string lastname = Console.ReadLine();
                        Console.Write("Enter Class (integer): ");
                        string cclass = Console.ReadLine();
                        Console.Write("Enter Section: ");
                        string section = Console.ReadLine();
                        AddRecord(id, firstname, lastname, cclass, section, teacherfile);
                        Console.WriteLine("Profile is successfully added to the Teacher record\n");
                        break;
                    case 3:
                        Console.Write("Enter ID of teacher (integer): ");
                        string iD = Console.ReadLine();
                        SearchByID(iD, listteacher);
                        break;
                    case 4:
                        Console.Write("Enter First Name of teacher: ");
                        string fname = Console.ReadLine();
                        SearchByFirstName(fname, listteacher);
                        break;
                    case 5:
                        Console.Write("Enter ID or First Name or Last Name or Class or Section of teacher to be updated: ");
                        string searchterm = Console.ReadLine();
                        Console.WriteLine("Enter 1 if you have entered ID previously\n" +
                            "Enter 2 if you have entered First Name previously\n" +
                            "Enter 3 if you have entered Last Name previously\n" +
                            "Enter 4 if you have entered Class previously\n" +
                            "Enter 5 if you have entered Section previously:");
                        int positionofsearchterm = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Enter new ID (integer): ");
                        string new_id = Console.ReadLine();
                        Console.Write("Enter new First Name: ");
                        string new_firstname = Console.ReadLine();
                        Console.Write("Enter new Last Name: ");
                        string new_lastname = Console.ReadLine();
                        Console.Write("Enter new Class (integer): ");
                        string new_cclass = Console.ReadLine();
                        Console.Write("Enter new Section: ");
                        string new_section = Console.ReadLine();
                        UpdateRecord(searchterm, teacherfile, positionofsearchterm, new_id, new_firstname, new_lastname, new_cclass, new_section);
                        break;
                    case 6:
                        SortByID(listteacher);
                        break;
                    case 7:
                        SortByFirstName(listteacher);
                        break;
                    case 8:
                        SortByLastName(listteacher);
                        break;
                    case 9:
                        SortByClass(listteacher);
                        break;
                    case 10:
                        SortBySection(listteacher);
                        break;
                    case 11:
                        Console.Write("Enter ID or First Name or Last Name or Class or Section of teacher to be deleted: ");
                        string deleteterm = Console.ReadLine();
                        Console.WriteLine("Enter 1 if you have entered ID previously\n" +
                           "Enter 2 if you have entered First Name previously\n" +
                           "Enter 3 if you have entered Last Name previously\n" +
                           "Enter 4 if you have entered Class previously\n" +
                           "Enter 5 if you have entered Section previously:");
                        int positionofdeleteterm = Convert.ToInt16(Console.ReadLine());
                        DeleteProfile(deleteterm, positionofdeleteterm, teacherfile);
                        break;
                    case 12:
                        exitFlag = false;
                        break;
                    default:
                        Console.WriteLine("Enter valid operation number");
                        break;
                }
            }
        }
        public static void Display(List<Teacher> listteacher)
        {
            Console.WriteLine("Unsorted Teacher record :");
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
            Console.WriteLine();
            Console.WriteLine($"Teacher profiles of ID {ob} :");
            bool found = false;

            foreach (Teacher tea in listteacher)
            {
                bool v = tea.ID.Equals(ob);
                if (v == true)
                {
                    found = true;
                    Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
                }
            }
            if (!found)
            {
                Console.WriteLine($"No profiles found");
            }
            Console.WriteLine();
        }

        public static void SearchByFirstName(Object ob, List<Teacher> listteacher)
        {
            Console.WriteLine();
            Console.WriteLine($"Teacher profiles of First Name {ob} : ");
            bool found = false;
            foreach (Teacher tea in listteacher)
            {
                bool v = tea.FirstName.Equals(ob);
                if (v == true)
                {
                    found = true;
                    Console.WriteLine($"{tea.ID} {tea.FirstName} {tea.LastName} {tea.Cclass} {tea.Section}");
                }
            }
            if (!found)
            {
                Console.WriteLine("No profiles found");
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
            Console.WriteLine("Profile is deleted");
        }

        public static void UpdateRecord(string SearchTerm, string filepath, int PositionOfSearchTerm, string fieldOne, string fieldTwo, string fieldThree, string fieldFour, string fieldFive)
        {
            PositionOfSearchTerm--;
            string tempfile = "temp.txt";
            bool edited = false;
            bool found = false;

            string[] lines = System.IO.File.ReadAllLines(@filepath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                bool v = fields[PositionOfSearchTerm].Equals(SearchTerm);
                if (v == false)
                {
                    found = true;
                    AddRecord(fields[0], fields[1], fields[2], fields[3], fields[4], @tempfile);
                }
                else
                {
                    if (!edited)
                    {
                        AddRecord(fieldOne, fieldTwo, fieldThree, fieldFour, fieldFive, @tempfile);
                        edited = true;
                    }
                }
            }
            File.Delete(@filepath);
            System.IO.File.Move(tempfile, filepath);
            if (!found)
                Console.WriteLine("The profile you entered is not found");
            else
                Console.WriteLine("Teacher profile updated successfully ");
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


    

