namespace team6_library_terminal;

public class Library
{
    public List<Book> Books { get; set; }

    public Library()
    {
        Books = new List<Book>();

        Books.Add(new Book("Night", "Elie Wiesl", false, ""));
        Books.Add(new Book("The Giver", "Lois Lowry", true, "06/21/25"));
        Books.Add(new Book("Of Mice And Men"," John Steinbeck",false,""));
        Books.Add(new Book("The City Of Ember","Jeanne DuPrau",true,"06/15/25"));
        Books.Add(new Book("Soul Eater Series","Atsushi Ohkubo",false,"") );
        Books.Add(new Book (" Their Eyes Were Watching God Novel","Zora Neale Hurston",true,"06/20/25" ));
        Books.Add(new Book("Things I Want To Say At Work But Can't: Swear Word Coloring Book For Adults Paperback","RH Publishing", true,"06/19/25"));
        Books.Add(new Book("Death Note Series", "Tsugumi Ohba", false,""));  
        Books.Add(new Book("To kill a mocking bird", "Harper Lee", false,"")); 
        Books.Add(new Book("The New Jim Crow Mass Incarceration in the Age of Colorblindnes", "Michelle Alexander", false,"" ));
        Books.Add(new Book("The Light We Carry", "Michelle Obama", true,"06/18/25" ));

    }
    
    public static void ReturnBook(List<Book> books)
    {
        Console.WriteLine("Enter the title of the book you want to return:");
        string returnBook = Console.ReadLine();
        foreach (Book abook in books)
        {
            if (abook.IsCheckOut)
            {
                abook.IsCheckOut = false;
                abook.DueDate = "";
                Console.WriteLine("Thanks for returning");
                return;
            }

        }

        Console.WriteLine("That book is not in our library:");

    }
    public static void SelectCheckoutBook(List<Book> books)

    {
        Console.WriteLine("Enter the title of the book you want to checkout");
        string checkOut = Console.ReadLine();
        foreach (Book abook in books)
        {
            if (abook.IsCheckOut)
            {
                Console.WriteLine("Sorry this book is already checked out");
            }
            else
            {
                abook.IsCheckOut = true;
                abook.DueDate = DateTime.Today.AddDays(14).ToShortDateString();


            }
        }


    }
    public static void SearchTitleKeyword(List<Book> books)

    {
        Console.WriteLine("Enter in the title:");
        string titleKeyword = Console.ReadLine();

        foreach (Book abook in books)
        {
            if (abook.Title == titleKeyword)
            {
                Console.WriteLine(abook);
            }
        }


    }
    public static void SearchAuthor(List<Book> books)


    {
        Console.WriteLine("Enter In The Authors Name:");
        string authorName = Console.ReadLine(); 

        foreach (Book abook in books)
        {

            if (abook.Author == authorName)
            {
                Console.WriteLine(abook);
            }

        }


    }
   
    


}