// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using HelloWorldLibrary;

class Program
{
    public static string? username = "";
    public static void Main(String[] args)
    {
        username = Console.ReadLine(); ;

        Console.Write($"Using Standard library: {Formatter.FormatOutput(username)} !!");

        string appName = @"C:\Users\Ajay_Batthula\source\repos\HelloWorld\HelloWorldForm\bin\Debug\HelloWorldForm.exe";
        Process.Start(appName, username);

        Console.ReadLine();

    }
}



