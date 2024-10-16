using System;
using System.Security.Cryptography;

public class Program
{
    public static string name;
    public static string age;
    public static string eyeColor;
    public static string hairColor;
    public static string shoeSize;
    public static string color;
    public static string movie;
    public static string teacher;
    public static string favClass;
    public static string holiday;
    public static string season;
    public static string dreamJob;
    public static int year;
    public static int siblings;


    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalulateAgeIn5Years(age);
        NumberOfSiblings();
        DisplaySummaryMessage();
    }
    public static void AskName() 
    {
         Console.WriteLine("Enter name");
         name = Console.ReadLine();
    }
     public static void AskAge() 
     {
        Console.WriteLine("Enter age");
         age = Console.ReadLine();
    }
     public static void AskEyeColor() 
     {
          Console.WriteLine("Enter eye color");
         eyeColor = Console.ReadLine();
    }
     public static void AskHairColor() 
     {
        Console.WriteLine("Enter hair color");
         hairColor = Console.ReadLine();
    }
     public static void AskShoeSize() 
     {
        Console.WriteLine("Enter shoe size");
         shoeSize = Console.ReadLine();
    }
     public static void AskFavoriteColor() 
     {
          Console.WriteLine("Enter color");
         color = Console.ReadLine();
    }
     public static void AskFavoriteTvShow() 
     {
        Console.WriteLine("Enter tv show or movie");
         movie = Console.ReadLine();
    }
     public static void AskFavoriteTeacher() 
     {
         Console.WriteLine("Enter teacher");
         teacher = Console.ReadLine();
    }
     public static void AskFavoriteClass() 
     {
          Console.WriteLine("Enter class");
         favClass = Console.ReadLine();
    }
     public static void AskFavoriteHoliday() 
     {
         Console.WriteLine("Enter holiday");
         holiday = Console.ReadLine();
    }
     public static void AskFavoriteSeason() 
     {
        Console.WriteLine("Enter season");
         season = Console.ReadLine();
    }
     public static void AskDreamJob() 
     {
         Console.WriteLine("Enter dream job");
         dreamJob = Console.ReadLine();
    }
     public static void CalulateAgeIn5Years(string age) 
     {
         year = Convert.ToInt32(age) + 5;
    }
     public static void NumberOfSiblings() 
     {
        Console.WriteLine("Enter the number of siblings you have");
         siblings = Convert.ToInt32(Console.ReadLine());
    }
     public static void DisplaySummaryMessage() 
     {
          Console.WriteLine("My friend's name is " + name + ".  " + name + " is " + age + " years old.  " + name + "'s eye color is " + eyeColor + ".  " +
         name + "'s hair color is " + hairColor + ".  " + name + "'s shoe size is " + shoeSize + ".  " + name + "'s favorite color is " + color + ".  " + name + "'s favorite tv show/movie is " + movie + ".  " + name + "'s favorite teacher is " + teacher + ".  " + 
         name + "'s favorite class is " + favClass + ".  " + name + "'s favorite holiday is " + holiday + ".  " + name + "'s favorite season is " + season + ".  " + name + "'s dream job is " + dreamJob + ".  " + name + " will be " + year + " in 5 years.  " 
         + name + " has " + siblings + " siblings.");
    }
}
