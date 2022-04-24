using System;
using System.Collections.Generic;
using System.Text;

namespace Task_10.Models
{
    class Student
    {
        private static int _id=0;
        public int Id { get;}
        public string Fullname { get; set; }
        public double Point { get; set; }

        public Student(string fullname,double point)
        {
            _id++;
            Id = _id++;
            Fullname = fullname;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Id:{Id}\nFullname:{Fullname}\nPoint:{Point}");
        }
    }
}
