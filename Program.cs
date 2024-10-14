using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter name");
        string name = Console.ReadLine();
       

        Console.WriteLine("Enter age");
        int age = Convert.ToInt32(Console.ReadLine());
        

        Console.WriteLine("Enter eye color");
        string eyeColor = Console.ReadLine();
       

        Console.WriteLine("Enter hair color");
        string hairColor = Console.ReadLine();
       

        Console.WriteLine("Enter shoe size");
        string shoeSize = Console.ReadLine();
        

        Console.WriteLine("Enter color");
        string color = Console.ReadLine();
       

        Console.WriteLine("Enter tv show or movie");
        string movie = Console.ReadLine();
        

        Console.WriteLine("Enter teacher");
        string teacher = Console.ReadLine();
        

        Console.WriteLine("Enter class");
        string favClass = Console.ReadLine();
     

        Console.WriteLine("Enter holiday");
        string holiday = Console.ReadLine();
        

        Console.WriteLine("Enter season");
        string season = Console.ReadLine();
        

        Console.WriteLine("Enter dream job");
        string dreamJob = Console.ReadLine();
        
        int year = age + 5;

        Console.WriteLine("Enter the number of siblings you have");
         int siblings = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("My friend's name is " + name + ".  " + name + " is " + age + " years old.  " + name + "'s eye color is " + eyeColor + ".  " +
         name + "'s hair color is " + hairColor + ".  " + name + "'s shoe size is " + shoeSize + ".  " + name + "'s favorite color is " + color + ".  " + name + "'s favorite tv show/movie is " + movie + ".  " + name + "'s favorite teacher is " + teacher + ".  " + 
         name + "'s favorite class is " + favClass + ".  " + name + "'s favorite holiday is " + holiday + ".  " + name + "'s favorite season is " + season + ".  " + name + "'s dream job is " + dreamJob + ".  " + name + " will be " + year + " in 5 years.  " 
         + name + " has " + siblings + " siblings.");
    }
}
