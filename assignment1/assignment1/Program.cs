using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using System.Transactions;

namespace assignment1
{


    public enum WeekDays
    {
             Monday
           , Tuesday
           , Wednesday
            ,Thursday
            ,Friday
            ,Saturday
           ,Sunday        
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            ///*Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            // * Then, write a C# program that prints out all the days of the week using this enum.*/

            //WeekDays weekDays = new WeekDays();
            //for (int i = 0; i < 7; i++)
            //    Console.WriteLine((weekDays)++);
            #endregion

            #region question2
            ///*
            // Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" 
            //objects and populate it with data. Then, write a C# program to display the details of all the persons in the array. */

            //Person[] people = new Person[3];

            //for (int i = 0; i < people.Length; i++) {
            //    Console.WriteLine($"enter age for user {i+1}");
            //int age=int.Parse(Console.ReadLine());
            //    Console.WriteLine($"enter name for user {i + 1}");
            //    string name= Console.ReadLine();    
            //    people[i]=new Person( age, name );
            //}

            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}



            #endregion

            #region question3

            // /*Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //  * Write a C# program that takes a season name as input from the user and displays the corresponding 
            //  * month range for that season. Note range for seasons ( spring march to may , summer june to august
            //  * , autumn September to November , winter December to February)*/
            // string user_input;
            // Season season=new Season();
            // bool isparsed=false;
            // do
            // {
            //     Console.WriteLine("enter season name");
            //     isparsed = Enum.TryParse<Season>(Console.ReadLine(),out season);
            //} while (!isparsed);


            // switch (season)
            // {
            //     case Season.Spring:
            //         Console.WriteLine("spring march to may"); break;
            //     case Season.Summer:
            //         Console.WriteLine("summer june to august"); break;
            //     case Season.Winter:
            //         Console.WriteLine("winter December to February"); break;
            //     case Season.Autumn:
            //         Console.WriteLine("autumn September to November"); break;
            //     default:
            //         break;
            // }

            #endregion

            #region question5
            ///*Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            // * Write a C# program that takes a color name as input from the user and displays a message
            // * indicating whether the input color is a primary color or not.*/
            //Colors color =new Colors();
            //bool isparsed=false;

            //do
            //{
            //    Console.WriteLine("enter the color");
            //    isparsed = Enum.TryParse<Colors>(Console.ReadLine(), out color);

            //} while (!isparsed);
            //switch (color)
            //{
            //    case Colors.Red:                   
            //    case Colors.Green:    
            //    case Colors.Blue:
            //        Console.WriteLine("is a prime color"); break;
            //    default:
            //        Console.WriteLine("not a prime color"); break;

            //}
            #endregion

            #region question6
            ///*Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            // * Write a C# program that takes two points as input from the user and calculates the distance between them.*/
            //Point [] point = new Point [2] ;

            //for (int i = 0; i < 2; i++) 
            //{
            //    double x, y;
            //    Console.WriteLine($"enter x for point {i+1}");
            //     x= int.Parse(Console.ReadLine());
            //    Console.WriteLine($"enter y for point {i + 1}");
            //    y = int.Parse(Console.ReadLine());
            //    point[i]= new Point (x,y);

            //}

            //Console.WriteLine(point[0].Distance(point[1]));

            #endregion


            #region question7
            ///*Create a struct called "Person" with properties "Name" and "Age"
            // * . Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.*/


            //Person[] people = new Person[3];

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"enter age for user {i + 1}");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"enter name for user {i + 1}");
            //    string name = Console.ReadLine();
            //    people[i] = new Person(age, name);
            //}
            //Person person=people[0].Oldest(people[1], people[2]);
            //Console.WriteLine($"name : {person.Name}, age : {person.Age}");

            #endregion

            #region part2

            Console.WriteLine("enter number of employee");
            int size=int.Parse(Console.ReadLine());
            Employee[] emp=new Employee[size];
            for (int i = 0; i < size; i++) 
            {
                Console.WriteLine($"enter data for employee {i+1}");
                emp[i]=new Employee();
                
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(emp[i]);  
            }

            #endregion

        }
    }
}
