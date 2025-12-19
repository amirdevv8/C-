using System;
using System.Collections.Generic;
using System.IO;

namespace UniversityApp
{//امیرمهدی میرفخرایی ساعت 2 تا 4:30 چهاررشنبه 
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }

        public override string ToString()
        {
            return $"{Id},{Name},{Major}";
        }
    }

    class StudentManager
    {
        private Dictionary<int, Student> students = new Dictionary<int, Student>();
        private string filePath = @"C:\UNI.txt";

        public StudentManager()
        {
            LoadFromFile();
        }

        public void AddStudent()
        {
            Console.Write("Student number : ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (students.ContainsKey(id))
            {
                Console.WriteLine(" This student is already registered..");
                return;
            }

            Console.Write("Student name: ");
            string name = Console.ReadLine();

            Console.Write("Field of study: ");
            string major = Console.ReadLine();

            students[id] = new Student { Id = id, Name = name, Major = major };
            SaveToFile();

            Console.WriteLine(" Student successfully registered..");
        }

        public void ShowStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine(" No student registered..");
                return;
            }

            foreach (var student in students.Values)
            {
                Console.WriteLine($"numner: {student.Id} | name: {student.Name} | Field of study: {student.Major}");
            }
        }

        public void RemoveStudent()
        {
            Console.Write("Student number to delete: ");
            int id = int.Parse(Console.ReadLine());

            if (students.Remove(id))
            {
                SaveToFile();
                Console.WriteLine(" Student was removed..");
            }
            else
            {
                Console.WriteLine(" Student not found.");
            }
        }

        private void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var student in students.Values)
                {
                    sw.WriteLine(student.ToString());
                }
            }
        }

        private void LoadFromFile()
        {
            if (!File.Exists(filePath))
                return;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    int id = int.Parse(parts[0]);
                    students[id] = new Student
                    {
                        Id = id,
                        Name = parts[1],
                        Major = parts[2]
                    };
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            StudentManager manager = new StudentManager();

            while (true)
            {
                Console.WriteLine("\n===== Main menu =====");
                Console.WriteLine("1. Registering student information");
                Console.WriteLine("2. Display student information");
                Console.WriteLine("3. Delete student");
                Console.WriteLine("4. Exit");
                Console.Write("Your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.AddStudent();
                        break;
                    case "2":
                        manager.ShowStudents();
                        break;
                    case "3":
                        manager.RemoveStudent();
                        break;
                    case "4":
                        Console.WriteLine(" Exit the program");
                        return;
                    default:
                        Console.WriteLine(" Invalid option!");
                        break;
                }
            }
        }
    }
}
