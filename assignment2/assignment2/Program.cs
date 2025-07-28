using Frist_project;
using Second_Project;
using third_project;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region first_project
            //Console.WriteLine($"enter data for Point {1}");
            //Point3D p1 = new Point3D(); p1.SetData();
            //Console.WriteLine($"enter data for Point {2}");
            //Point3D p2 = new Point3D(); p2.SetData();

            //if (p1 == p2) Console.WriteLine("p1 is equal p2");
            //else Console.WriteLine("p1 is not equal p2"); ;
            #endregion

            #region second_project

            //Console.WriteLine($"Multiplication:{ _Math.Multiply(2, 5)}");
            //Console.WriteLine($"Addition :{_Math.Add(2, 5)}");
            //Console.WriteLine($"Subtraction :{_Math.Sub(2, 5)}");
            //Console.WriteLine($"Division :{_Math.Division(2, 5)}");




            #endregion

            #region third_project

            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());
            //Console.WriteLine("------------------------------------------");
            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString());
            //Console.WriteLine("------------------------------------------");
            //Duration D3= new Duration(7817);
            //Console.WriteLine(D3.ToString());
            //Console.WriteLine("------------------------------------------");
            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());
            //Console.WriteLine("------------------------------------------");
            //D3=D1 + D2;
            //Console.WriteLine(D3);
            //Console.WriteLine("------------------------------------------");
            //D3 = D1 +7800;
            //Console.WriteLine(D3);
            //Console.WriteLine("------------------------------------------");
            //D3 = 666 + D3;
            //Console.WriteLine(D3);
            //Console.WriteLine("------------------------------------------");
            //D3 = ++D1;
            //Console.WriteLine(D3);
            //D3 = --D1;
            //Console.WriteLine(D3);

            //D1 = D1 - D2;
            Duration D1 = new Duration(3600);
            Duration D2 = new Duration(7600);
             if(D1 > D2) Console.WriteLine("D1 is greater than D2"); else Console.WriteLine("D1 less than D2");
            Console.WriteLine("------------------------------------------");
            if (D1 <= D2) Console.WriteLine("D2 is greater than or equal D1"); else Console.WriteLine("D2 less than D1 ");
            Console.WriteLine("------------------------------------------");
            if (!D1) Console.WriteLine("D1 is false");else Console.WriteLine("D1 is true");











            #endregion
        }
    }
}
