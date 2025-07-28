namespace Frist_project
{
    public class Point3D
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }
      

        public Point3D() 
        {
            
        }
      
        public Point3D(int _x,int _y,int _z) :this()
        {
            X = _x;
            Y = _y;
            Z = _z;    
        }


        public override string ToString()
        {
            return $"X : {X} ,Y :{Y} , Z : {Z}";
        }

        public void SetData()
        {
            bool xparsed=false;
            do
            {
                Console.WriteLine("enter point X");
                xparsed = int.TryParse(Console.ReadLine(), out x);
            } while (!xparsed);
            bool yparsed = false;
            do
            {
                Console.WriteLine("enter point Y");
                yparsed = int.TryParse(Console.ReadLine(), out y);
            } while (!yparsed);

            bool zparsed = false;
            do
            {
                Console.WriteLine("enter point Z");
                zparsed = int.TryParse(Console.ReadLine(), out z);
            } while (!zparsed);
        }

        public static bool operator ==(Point3D a, Point3D b)
        {
            if((a?.x??0) == (b?.x??0) && (a?.y??0)==(b?.y??0)&&(a?.z??0)==(b?.z??0))
                return true;
            else return false;

        }
        public static bool operator !=(Point3D a, Point3D b)
        {
            if ((a?.x ?? 0) == (b?.x ?? 0) && (a?.y ?? 0) == (b?.y ?? 0) && (a?.z ?? 0) == (b?.z ?? 0))
                return false;
            else return true;

        }



    }
}
