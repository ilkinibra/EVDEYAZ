using System;
using Task_10.Models;

namespace Task_10
{
    class Program
    {
        public static bool CheckGroupNo(string groupNo)
        {
            bool HasDigit = false;
            foreach (var item in groupNo)
            {
                if (char.IsDigit(item))
                {
                    HasDigit = true;
                }
                else if (groupNo == groupNo.Remove(1))
                {
                    return true;
                }
                bool result = HasDigit;
                return result;
            }
            return false;
        }
        public static bool PasswordChecker(string Password)
        {
            bool HassUpper = false;
            bool HasLower = false;
            bool HasDigit = false;
            if (Password.Length > 8)
            {
                foreach (var item in Password)
                {
                    if (char.IsUpper(item))
                    {
                        HassUpper = true;
                        continue;
                    }
                    if (char.IsLower(item))
                    {
                        HasLower = true;
                        continue;
                    }
                    if (char.IsDigit(item))
                    {
                        HasDigit = true;

                    }
                    bool resault = HasDigit && HasLower && HassUpper;
                    return resault;
                }

            }
            return false;
        }
        static void Main(string[] args)
        {
            Group group = null;
            string groupNo;
            Console.WriteLine("enter fullname");
            string fullname = Console.ReadLine();
            Console.WriteLine("enter email");
            string email = Console.ReadLine();
            string password;
            int studentlimit;

            do
            {
                Console.WriteLine("enter password");
                password = Console.ReadLine();
            } while (!PasswordChecker(password));
            Console.WriteLine("******MENU1******");
            Console.WriteLine("1.Show info");
            Console.WriteLine("2.Create new group");
            Console.WriteLine("3.New Menu");

            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    User user = new User(fullname, email, fullname);
                    user.ShowInfo();
                    break;
                case 2:
                    Console.WriteLine("");
                    do
                    {
                        Console.WriteLine("enter groupno");
                        groupNo = Console.ReadLine();
                    } while (!CheckGroupNo(groupNo));

                    do
                    {
                        Console.WriteLine("enter studentlimit");
                        studentlimit = Convert.ToInt32(Console.ReadLine());
                        group = new Group(groupNo, studentlimit);
                    } while (studentlimit < 6 || studentlimit >= 18);

                    break;

                    //do
                    //{
                    //    Console.WriteLine("******MENU2******);
                    //    Console.WriteLine("1. Show all students");
                    //    Console.WriteLine("2. Get student by id");
                    //    Console.WriteLine("3. Add student");
                    //    Console.WriteLine("0. Quit");
                    //    num = Convert.ToInt32(Console.ReadLine());
                    //    switch (num)
                    //    {
                    //        case 1:
                    //            group.GetAllStudents();
                    //            return;
                    //        case 2:
                    //            Console.WriteLine("Student id daxil edin");
                    //            student.Id = Convert.ToInt32(Console.ReadLine());
                    //            Console.WriteLine(group.GetStudent(student.Id));
                    //            return;
                    //        case 3:
                    //            Console.Write("Fullname:");
                    //            string FullName = Console.ReadLine();
                    //            Console.Write("Point:");
                    //            int point = Convert.ToInt32(Console.ReadLine());
                    //            Student student = new Student(fullname, point);
                    //            group.AddStudent(student);
                    //            return;
                    //        default:
                    //            return;
                    //    }
                    //} while (num != 0);

                default:
                    return;
            }
        }
    }
}

          
