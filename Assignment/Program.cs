/*Circle
class circle
    {
        static void Main(string[] args)
        {
            double r,perimeter, area;
            r = Convert.ToDouble(Console.ReadLine());
            perimeter = 2 * 3.14 * r;
            area = 3.14 * Math.Pow(r, 2); 
            Console.WriteLine(" perimeter  : {0}",perimeter);
            Console.WriteLine("area : {0} ", area);
           
        }
    }*/
/*distance
public class time
{
    public static void Main()
    {
        float distance;
        float hour, min, sec;
        float timeSec;
        float kph, mph;

        distance = Convert.ToSingle(Console.ReadLine());
       
        hour = Convert.ToSingle(Console.ReadLine());
        
        min = Convert.ToSingle(Console.ReadLine());
        
        sec = Convert.ToSingle(Console.ReadLine());

        timeSec = (hour * 3600) + (min * 60) + sec;
        kph = (distance / 1000.0f) / (timeSec / 3600.0f);
        mph = kph / 1.609f;
        Console.WriteLine("Your speed in km/h is {0}", kph);
        Console.WriteLine("Your speed in miles/h is {0}", mph);
    }
}*/
/*evenodd
public class evenodd
{
    public bool Main()
    {
        int num1, num2;
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 % 2 == 0 && num2 % 2 == 0 || num1 % 2 != 0 && num2 % 2 != 0)
            return true;
        else
            return false;
    }
}*/
/*leapyear
class Program
{
    static void Main(string[] args)
    {
        int Year = Convert.ToInt32(Console.ReadLine());
        if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) Console.WriteLine("{0} is a Leap Year.", Year);
        else Console.WriteLine("{0} is not a Leap Year.", Year);
        Console.ReadLine();
    }
}*/
/*height
public class height
{
    public static void Main(string[] args)
    {
        int height=Convert.ToInt32(Console.ReadLine());
        if (height < 135)
            Console.WriteLine("short");
        else if (height > 180)
            Console.WriteLine("tall");
        else 
            Console.WriteLine("average");

    }
}*/
/* marks
public class marks
{
    public static void Main(string[] args)
    {
        int maths = Convert.ToInt32(Console.ReadLine());
        int phy = Convert.ToInt32(Console.ReadLine());
        int chem = Convert.ToInt32(Console.ReadLine());
        if (maths >= 65 && phy >= 55 && chem >= 50)
            Console.WriteLine("eligible");

        else
            Console.WriteLine("not eligible");

    }
}*/

