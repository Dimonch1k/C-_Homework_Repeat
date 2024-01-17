namespace MyLibrary
{
    public class Library
    {
        // Create list of books
        public List<Book> books = new List<Book>();

        // Create list of removed books
        public List<Book> delBooks = new List<Book>();


        // Add Book to the list "books"
        public void AddBook(Book book)
        {
            books.Add(book);
        }


        // Give Book to visitor. Remove book from the list "books". Add it to the list "delBooks"
        public void GiveBook(Book book) 
        {
            delBooks.Add(book);
            books.Remove(book);
        }

       
        // Get back the book from visitor. Add it to the List "books". Remove this book from the List "delBooks"
        public void GetBackBook(Book book)
        {
            books.Add(book); // Get back book to the List "books"
            delBooks.Remove(book); // Remove the book from the List "delBooks"
        }


        // Print all books, which are in the List "books"
        public void PrintAllBooks()
        {
            Console.WriteLine("All Books:");
            books.ForEach(x => PrintBook(x));
        }


        // Additional function for method "PrintAllBooks"
        private string PrintBook(Book book)
        {
            return ($"  Name: {book.Name}\n" +
                    $"  Author: {book.Author}\n" +
                    $"  Id: {book.Id}\n\n"
                    );
        }
    }
}
