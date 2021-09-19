using System;


class Program
{
    static void Main()
        {
        Console.WriteLine("The Tech Academy.");
        Console.WriteLine("Student Daily Report.");
        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();      
        //Console.WriteLine("Your name is: " + yourName);  //wasn't sure if we needed it to read back our answers.
        Console.WriteLine("What course are you on?");
        string yourCourse = Console.ReadLine(); 
        Console.WriteLine("What page number?");
        string yourPage = Console.ReadLine();
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
        string yourhelp = Console.ReadLine();
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string yourExperiences = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string yourFeedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string yourHours = Console.ReadLine();
        Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day! This is the end of the program.");
        Console.ReadLine(); //keep window up after displaying data

    }
}
