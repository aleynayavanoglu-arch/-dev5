using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    private int pages;
    public int Pages
    {
        get { return pages; }
        set
        {
            if (value > 0) pages = value;
            else Console.WriteLine("Pages must be > 0!");
        }
    }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public string Info()
    {
        return Title + " by " + Author + ", " + Pages + " pages";
    }
}

class Program
{
    static void Main()
    {
        Book[] books = new Book[3];
        books[0] = new Book("1984", "George Orwell", 328);
        books[1] = new Book("Dune", "Frank Herbert", 412);
        books[2] = new Book("The Hobbit", "J.R.R. Tolkien", 310);

        foreach (Book b in books)
            Console.WriteLine(b.Info());

        Book max = books[0];
        foreach (Book b in books)
            if (b.Pages > max.Pages) max = b;

        Console.WriteLine("Most pages: " + max.Info());
    }
}