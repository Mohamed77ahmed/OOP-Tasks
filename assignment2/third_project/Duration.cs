namespace third_project
{
    public class Duration
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public Duration()
        {
            
        }
        public Duration(int _hour,int _minute,int _second)
        {
            Hour = _hour;
            Minute =_hour;
            Second = _second ;
        }

        public Duration(int _second)
        {
            Hour =_second/3600;
            Minute = _second%360;
            Second = _second%60;
        }

        public override string ToString()
        {
            return $"Hours : {Hour} , Minutes : {Minute} Seconds {Second}"  ;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public static Duration operator +(Duration a, Duration b)
        {
            return new Duration
            {
                Hour = (a?.Hour??0 )+ (b?.Hour??0),
                Minute = (a?.Minute??0) + (b?.Minute??0),
                Second = (a?.Second??0) + (b?.Second??0)


            };
        }
        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration
            {
                Hour = (a?.Hour ?? 0) - (b?.Hour ?? 0),
                Minute = (a?.Minute ?? 0) - (b?.Minute ?? 0),
                Second = (a?.Second ?? 0) - (b?.Second ?? 0)


            };
        }

        public static Duration operator --(Duration a)
        {
            return new Duration
            {
           
                Minute = (a?.Minute ?? 0) - 1,
          
            };
        }
        public static Duration operator ++(Duration a)
        {
            return new Duration
            {
            
                Minute = (a?.Minute ?? 0) + 1
              
            };
        }

        public static bool operator ==(Duration a, Duration b)
        {
            if(
             (a?.Hour ?? 0) ==(b?.Hour ?? 0)&&
               (a?.Minute ?? 0) ==(b?.Minute ?? 0)&&
                (a?.Second ?? 0)== (b?.Second ?? 0))
                return true;
            else return false;


        }
        public static bool operator !=(Duration a, Duration b)
        {
            if (
             (a?.Hour ?? 0) == (b?.Hour ?? 0) &&
               (a?.Minute ?? 0) == (b?.Minute ?? 0) &&
                (a?.Second ?? 0) == (b?.Second ?? 0))
                return true;
            else return false;



        }


        public static bool operator >(Duration a, Duration b)
        {
            if (
             (a?.Hour ?? 0) > (b?.Hour ?? 0) &&
               (a?.Minute ?? 0) > (b?.Minute ?? 0) &&
                (a?.Second ?? 0) > (b?.Second ?? 0))
                return true;
            else return false;



        }



        public static bool operator <(Duration a, Duration b)
        {
            if (
             (a?.Hour ?? 0) < (b?.Hour ?? 0) &&
               (a?.Minute ?? 0) < (b?.Minute ?? 0) &&
                (a?.Second ?? 0) < (b?.Second ?? 0))
                return true;
            else return false;



        }

       



    }
}
