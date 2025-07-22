using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace assignment1
{

    public enum Gender
    {
        Male=0
            ,male=0,
        Female=1,
        female=1
    }

   public class HireDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate()
        {
            
        }
        public HireDate(int _day,int _month,int _year)
        {

            Day = _day;
            Month = _month;  
            Year = _year;
          

            
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
       




    }



    internal class Employee
    {
        
        private int id;
        private string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public Gender Gender { get; set; }
        
        public Security_level Security_level { get; set; }
        //public HireDate Hiredate { get; set; }
        private HireDate hiredate;

        public HireDate HireDate
        {
            get { return hiredate; }
            set { hiredate = value; }
        }

        HireDate Hiredate;
        public Employee()
        {
           

        }

        public void SetData()
        {
            bool idparsed=false;
            do
            {
                Console.Write("Enter ID: ");
                idparsed = int.TryParse(Console.ReadLine(), out id );
            } while (!idparsed);
          

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            bool salaryparsed = false;
            do
            {
                Console.Write("Enter Salary: ");
                salaryparsed = decimal.TryParse(Console.ReadLine(), out salary);
            } while (!salaryparsed);
           
            Salary = decimal.Parse(Console.ReadLine());

            Gender gender = new Gender();
            Console.Write("Enter Gender (Male/Female): ");
            while (!Enum.TryParse(Console.ReadLine(), true, out gender) || !(gender == Gender.Male || gender == Gender.Female))
            {
                Console.Write("Invalid. Enter M or F: ");
            }

            Security_level security;
            Console.Write("Enter Security Level (Guest, Developer, Secretary, DBA): ");
            while (!Enum.TryParse<Security_level>(Console.ReadLine(), true, out security))
            {
                Console.Write("Invalid. Try again: ");
            }


   
            Console.Write("Enter Day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Enter Month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());

             Hiredate = new HireDate(day, month, year);
        }
     
       
        public override string ToString()
        {
            
            return $"ID: {Id}, Name: {Name}, Gender: {Gender}, Security Level: {Security_level}, Salary: {string.Format("{0:C}", Salary)}, Hire Date:{Hiredate.ToString()} ";
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
