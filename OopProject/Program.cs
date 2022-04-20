using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string OneClassFile = "D:\\wipro\\.net\\OneClass.txt";
            string StudentFile = "D:\\wipro\\.net\\Students.txt";
            string SubjectsFile = "D:\\wipro\\.net\\Subjects.txt";

            List<OneClass> listoneclass = new List<OneClass>();
            List<Student> liststudent = new List<Student>();
            List<Subject> listsubject = new List<Subject>();

            string[] arroneclass = System.IO.File.ReadAllLines(OneClassFile);

            foreach ( string line in arroneclass)
            {
                string[] l = line.Split(',');
                OneClass oneclass = new OneClass();
                oneclass.Grade = l[0];
                oneclass.Section = l[1];
                listoneclass.Add(oneclass);
            }

            string[] arrstudent = System.IO.File.ReadAllLines(StudentFile);
            
            foreach(string line in arrstudent)
            {
                string[] l = line.Split(',');
                Student student = new Student();
                student.Name = l[0];
                student.Grade = l[1];
                student.Section = l[2];
                liststudent.Add(student);
            }

            string[] arrsubject = System.IO.File.ReadAllLines(SubjectsFile);

            foreach(string line in arrsubject)
            {
                string[] l = line.Split(',');
                Subject subject = new Subject();
                subject.Name = l[0];
                subject.Code = l[1];
                subject.Teacher = l[2];
                subject.Grade = l[3];
                subject.Section = l[4];
                listsubject.Add(subject);
            }

            foreach( OneClass oc in listoneclass)
            {
                Console.WriteLine($"Class: {oc.Grade} {oc.Section}");
                Console.WriteLine();
                Console.WriteLine("Students: ");
                foreach( Student s in liststudent)
                {
                    if (s.Grade == oc.Grade && s.Section==oc.Section)
                        Console.WriteLine($"{ s.Name}");
                }
                Console.WriteLine();
                Console.WriteLine("Subjects: ");
                foreach(Subject sub in listsubject)
                {
                    if (sub.Grade == oc.Grade && sub.Section == oc.Section)
                        Console.WriteLine($"{sub.Name} {sub.Teacher}");
                }
                Console.WriteLine();
            }
        }
    }
}
