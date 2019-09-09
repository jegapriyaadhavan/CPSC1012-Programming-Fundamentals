using System;
public class average{
    public static void Main(string[] args)
    { 
        double x,y,z,a ,average;
        
        
        Console.WriteLine("Enter 1st number:");
        x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd number:");
        y = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter 3rd number:");
        z = double.Parse(Console.ReadLine());

        a = (x + y + z);
        average = a/3;
        Console.WriteLine("Average = " + average);


    }

}