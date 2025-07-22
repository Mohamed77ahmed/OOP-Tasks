using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace assignment1
{
    internal struct Person 
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(int _id,string _name)
        {
            Age = _id;
            Name = _name;
                  
        }
        public Person Oldest(Person two, Person three)
        {

            Person oldest = this;

            if (two.Age > oldest.Age)
                oldest = two;

            if (three.Age > oldest.Age)
                oldest = three;

            return oldest;
        }
       



    }

    public enum Season
    { 
    Spring=0
   ,spring=0,
    Summer=1,
    summer=1,
    Winter=2,
    winter=2,
    Autumn=3
    ,autumn=3
    }

    public enum Colors
    {

        Red = 0,
        red = 0
        ,Green=1 
        ,green=1
        ,blue=2
        ,Blue=2
    }

    public struct Point
    {
        public double X 
        { get; set; 
        }
        public double Y { get; set; }

        public Point(double _x,double _y)
        {
            X = _x;
            Y = _y;     
        }

        public double Distance(Point other)
        {
            double dx = other.X - this.X;
            double dy = other.Y - this.Y;
            return Math.Sqrt(dx * dx + dy * dy);

        }

    }


  

}
