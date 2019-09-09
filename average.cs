using System;
public class average{
    public static void Main(string[] args)
    { 
        double x,y,z,a ,average;
        
        
        Console.WriteLine("Enter 3 real numbers:");
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        z = double.Parse(Console.ReadLine());

        a = (x + y + z);
        average = a/3;
        Console.WriteLine("Average = " + average);


    }

}