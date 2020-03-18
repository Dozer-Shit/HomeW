using System;
using System.Collections.Generic;
// Для пулл реквеста
namespace HomeWork6
{
    class Student
    {
        public int Course { get; }
        public string Department { get; }
        public int Group { get; }
        public string City { get; }
        public int Age { get; }

        public string LastName { get; }

        public string FirstName { get; }

        public string Univercity { get; }

        public string Faculty { get; }

        public Student(string firstName, string lastName, string univercity, string faculty, string department, int age,
            int course, int group, string city)
        {
            LastName = lastName;
            FirstName = firstName;
            Univercity = univercity;
            Faculty = faculty;
            Department = department;
            Course = course;
            Age = age;
            Group = group;
            City = city;
        }

        public static void CalcStud(List<Student> list)
        {
            List<Student> newlist = new List<Student>();
            Student t;
            int[] courseStud = new int[7];
            for (int i = 0; i < list.Count; i++)
            {
                t = list[i];
                if (t.Age >= 18 && t.Age <= 20)
                {
                    newlist.Add(t);
                    courseStud[t.Course]++;
                }
            }

            Console.WriteLine($"Cтудентов в возрасте 18-20: {newlist.Count}");
            Console.WriteLine($"1 курс: {courseStud[1]}");
            Console.WriteLine($"2 курс: {courseStud[2]}");
            Console.WriteLine($"3 курс: {courseStud[3]}");
            Console.WriteLine($"4 курс: {courseStud[4]}");
            Console.WriteLine($"5 курс: {courseStud[5]}");
            Console.WriteLine($"6 курс: {courseStud[6]}");
        }

        public static int SortAge(Student st1, Student st2)
        {
            if (st1.Age > st2.Age)
            {
                return 1;
            }

            if (st1.Age < st2.Age)
            {
                return -1;
            }

            return 0;
        }

        public static int SortCourse(Student st1, Student st2)
        {
            if (st1.Course > st2.Course)
            {
                return 1;
            }

            if (st1.Course < st2.Course)
            {
                return -1;
            }

            return 0;
        }

        public static int SortByAgeAndCourse(Student st1, Student st2)
        {
            if (st1.Age > st2.Age)
            {
                return 1;
            }

            if (st1.Age < st2.Age)
            {
                return -1;
            }

            if (st1.Course > st2.Course)
            {
                return 1;
            }

            if (st1.Course < st2.Course)
            {
                return -1;
            }

            return 0;
        }
    }
}