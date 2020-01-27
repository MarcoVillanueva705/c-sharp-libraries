using System;
using console_library.Models;

namespace console_library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book ch = new Book("Can't Hurt Me","David Goggins", 324 );
            Book ls = new Book("Lone Survivor","Marcus Litrell", 275 );
            Library myLibrary = new Library("Jojo's Library Stand");
            
            Console.Clear();
            System.Console.WriteLine("Welcome to the Library");
            
            myLibrary.AddBook(ch);
            myLibrary.AddBook(ls);
            myLibrary.PrintBooks();
            // System.Console.WriteLine($"{ch.Title} {ch.Author} - {(ch.Available ? "Available" :"Checked Out")}");
            // System.Console.WriteLine("What is your name?");
            // string name=  System.Console.ReadLine();
            // System.Console.WriteLine("Hello " + name);
            // bool gotUserName = true;
            // if(gotUserName){
            //     System.Console.WriteLine("How old are you?");
            //     string ageString = System.Console.ReadLine();
            //     int age;
            //     if(Int32.TryParse(ageString, out age))
            //     {
            //         System.Console.WriteLine("You are "+age+ "years old");
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Invalid age");
            //     }
        }
    
            // myBook.Author = "Shel Silverstein";
            // myBook.Title = "Where the Sidewalk Ends";
            // Console.WriteLine("Hello World!");
    }
}

