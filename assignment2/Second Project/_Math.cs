namespace Second_Project
{
    public class _Math
    {
        public double X{ get; set; }
        public double y{ get; set; }

        public _Math()
        {
            
        }

        public static double Add(double x, double y) 
        { 
            return x + y;   
        }

        public static double Sub(double x, double y)
        {
            return x -y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Division(double x, double y)
        {
            return x / y;
        }

    }
}
