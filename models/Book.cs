using System.Collections.Generic;


namespace console_library.Models
{
    public class Book
    {
        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public bool Available { get; set; }
    
        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Available = true;
        
        }

        // private List<Book> Books { get; set; } = new List<Book>();
    
        // public void AddBook(List<Book> books)
        // {
        // Books.AddRange(books);

        // }

        // public void PrintBooks()
        // {
        // for(int i = 0; i < Books.Count; i++)
        // {
        // System.Console.WriteLine($"{i+1} {Books[i].Title} - {Books[i].Author}");

        // }
        // }
    }
}