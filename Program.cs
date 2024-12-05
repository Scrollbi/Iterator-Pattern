using Iterator_Pattern;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        library.AddBook(new Book("Книга №1", "Автор №1", 2000));
        library.AddBook(new Book("Книга №2", "Автор №2", 2001));
        library.AddBook(new Book("Книга №3", "Автор №3", 2002));

        foreach (var book in library) Console.WriteLine(book);
        
    }
}
