namespace team6_library_terminal;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        bool running = true;
        while (running)
        {

            Console.WriteLine("\nPlease choose an option");
            Console.WriteLine("1. Display all Books");
            Console.WriteLine("2. Search by Author");
            Console.WriteLine("3. Search for a book by title keyword.");
            Console.WriteLine("4. Checkout a Book");
            Console.WriteLine("5. Return a Book");
            Console.WriteLine("6. Exit");

            Console.WriteLine("Enter Your Choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
             
              case 1:
                  Display(library.Books);
                  break;
              case 2:
                  Library.SearchAuthor(library.Books);
                  break;
              case 3: 
                  Library.SearchTitleKeyword(library.Books);
                  break;
              case 4: 
                  Library.SelectCheckoutBook(library.Books);
                  break;
              case 5: 
                  Library.ReturnBook(library.Books);
                  break;
            
              case 6:
                  running = false;
                  break;
              
              default:
                  Console.WriteLine("Invalid option try again");
                  break;
              
                  
            }
            //bool ifBookIsCheckedOut = true;
            // bool ifBookIsNotCheckedOut = false;

            // Console.WriteLine("ifBookIsCheckedOut");
            // Console.WriteLine("ifBookIsNotCheckedOut");
            // Display(library.Books);

            // (Library.SearchAuthor());
        }
    } // End of main

    public static void Display(List<Book> books)
    {
        foreach (Book abook in books)
        {
            Console.WriteLine(abook.Title);
        }

    }









} // End of Program Class 