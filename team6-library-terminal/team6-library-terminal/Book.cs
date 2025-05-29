namespace team6_library_terminal;

public class Book
{
    public string Title { get; set; } 
    public string Author { get; set; }
    public bool IsCheckOut { get; set; }
    public string DueDate { get; set; }

    public Book(string title, string author, bool isCheckOut, string dueDate)
    {
        Title = title;
        Author = author;
        IsCheckOut = isCheckOut;
        DueDate = dueDate;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, DueDate: {DueDate}";
    }
}