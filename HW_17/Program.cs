using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_17
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter student's name");
            Student name = new Student(Console.ReadLine());

            s1:
            Console.WriteLine("Enter grade in Math 1 to 12");
            int ballMath = int.Parse(Console.ReadLine());
            if (ballMath > 12 || ballMath <= 0)
            {
                Console.Write("You enter not correct grade. Try again" + "\n");
                goto s1;
            }

            s2:
            Console.WriteLine("Enter grade in Literature 1 to 12");
            int ballliterature = int.Parse(Console.ReadLine());
            if (ballliterature > 12 || ballliterature <= 0)
            {
                Console.Write("You enter not correct grade. Try again" + "\n");
                goto s2;
            }

            s3:
            Console.WriteLine("Enter grade in Physicse 1 to 12");
            int ballphysics = int.Parse(Console.ReadLine());
            if (ballphysics > 12 || ballphysics <= 0)
            {
                Console.Write("You enter not correct grade. Try again" + "\n");
                goto s3;
            }

            s4:
            Console.WriteLine("Enter grade in Physical class 1 to 12");
            int ballPhysicalT = int.Parse(Console.ReadLine());
            if (ballPhysicalT > 12 || ballPhysicalT <= 0)
            {
                Console.Write("You enter not correct grade. Try again" + "\n");
                goto s4;
            }

            name.Diary.AddMark(ballMath);
            name.Diary.AddMark(ballliterature);
            name.Diary.AddMark(ballphysics);
            name.Diary.AddMark(ballPhysicalT);
            

            Console.WriteLine($"Max mark:\t{name.Diary.MaxMark}");
            Console.WriteLine($"Min mark:\t{name.Diary.MinMark}");
            Console.WriteLine($"Average mark:\t{name.Diary.AverageMark}");
        }
    }

    public class Diary
    {
        private readonly IList<int> marks;

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < marks.Count)
                {
                    return marks[index];
                }

                throw new IndexOutOfRangeException();
            }
            // На случай ошибочно выставленной оценки
            set
            {
                if (index >= 0 && index < marks.Count)
                {
                    marks[index] = value;
                }

                throw new IndexOutOfRangeException();
            }
        }

        public Diary()
        {
            marks = new List<int>();
        }

        public void AddMark(int mark)
        {
            // Проверка корректности оценки (по 5-ти бальной системе)
            if (mark > 0 && mark <= 12)
            {
                this.marks.Add(mark);
                return;
            }

            throw new IndexOutOfRangeException(nameof(mark));
        }

        public int MaxMark => marks.Max();

        public int MinMark => marks.Min();

        public double AverageMark => marks.Average();
    }

    public class Student
    {
        public string Name { get; set; }

        public Diary Diary { get; private set; }

        public Student(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(nameof(name));

            Name = name;
            Diary = new Diary();
        }
    }
}
