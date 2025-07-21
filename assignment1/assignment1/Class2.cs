using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{

    public enum Gender
    {
        Male,
        Female
    }

   public class HireDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int _day,int _month,int _year)
        {

            Day = _day;
            Month = _month;
                
            Year = _year;
            //Console.Write("Enter Day: ");
            //int Day = int.Parse(Console.ReadLine());

            //Console.Write("Enter Month: ");
            //int Month = int.Parse(Console.ReadLine());

            //Console.Write("Enter Year: ");
            //int Year = int.Parse(Console.ReadLine());

            
        }

        public override string ToString()
        {
            return $"{Day}//{Month}//{Year}";
        }
       




    }



    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public decimal Salary { get; set; }
        public Security_level Security_level { get; set; }
        public HireDate Hiredate { get; set; }

        public Employee()
        {
            Console.Write("Enter ID: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            Salary = decimal.Parse(Console.ReadLine());

            Gender gender =new Gender();
            Console.Write("Enter Gender (Male/Female): ");
            while (!Enum.TryParse(Console.ReadLine(), true, out  gender) || !(gender == Gender.Male || gender == Gender.Female))
            {
                Console.Write("Invalid. Enter M or F: ");
            }

            Security_level security;
            Console.Write("Enter Security Level (Guest, Developer, Secretary, DBA): ");
            while (!Enum.TryParse<Security_level>(Console.ReadLine(), true, out  security))
            {
                Console.Write("Invalid. Try again: ");
            }


           // HireDate hiredate = new HireDate();
            Console.Write("Enter Day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Enter Month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());

            HireDate hireDate = new HireDate(day, month, year);

        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {Gender}, Security Level: {Security_level}, Salary: {string.Format("{0:C}", Salary)}, Hire Date: {Hiredate}  ";
        }

    }



    public enum Security_level
    {
        guest,
        Developer,
        secretary,
        DBA
    }
}
