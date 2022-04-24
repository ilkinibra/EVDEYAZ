using System;
using System.Collections.Generic;
using System.Text;

namespace Task_10.Models
{
    class Group
    {
        private string _groupNo;
        public string GroupNo { get; set; }
        private int _studentLimit;
        public int StudentLimit
        {
            get { return _studentLimit; }
            set {
                if (value >= 5 && value <= 18)
                {
                    _studentLimit = value;
                    return;
                }
                Console.WriteLine("Min: 5  Max: 18");
                return;
            }
        }
        private Student[] Students = new Student[0];
        public bool CheckGroupNo(string groupNo)
        {
            for (int i = 0; i < groupNo.Length; i++)
            {
                if (groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                {
                    _groupNo = groupNo;
                    return true;
                }
            }
            return false;
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
        public void GetStudent(int? Id)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == Id)
                {
                    Console.WriteLine($"Fullname:{Students[i].Fullname}\nPoint: {Students[i].Point}");
                }
            }
        }
        public void GetAllStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"Id: {Students[i].Id} \nFullname:{Students[i].Fullname} \nPoint: {Students[i].Point}");
            }
        }
        public Group(string groupNo,int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }
    }
}
