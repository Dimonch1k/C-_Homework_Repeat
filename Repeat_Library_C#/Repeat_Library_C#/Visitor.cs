namespace MyLibrary
{
    public class Visitor<N, A>
    {
        public N Name { get; set; } // Create variable Name
        public A Age { get; set; }  // Create variable Age


        // Method TakeBook
        public string TakeBook(Library library, int id)
        {
            if (IsEmpty(library)) return "The list is empty!!!\n\n";

            if (IsInLibrary(library, id))
            {
                Book isInBooks = library.books.FirstOrDefault(x => x.Id == id);
                if (isInBooks != null)
                {
                    PrintBook(isInBooks);
                    library.GiveBook(isInBooks);
                    return "";
                }
            }
            return "There is no book with this name!!!\n\n";
        }
        private bool IsInLibrary(Library library, int id) // Method for TakeBook
        {
            if (IsEmpty(library)) return false;

            return library.books.Any(x => x.Id == id);
        }
        private bool IsEmpty(Library library) // Method for TakeBook
        {
            if (library == null) return true;
            return false;
        }
        private void PrintBook(Book book) // Method for TakeBook
        {
            Console.WriteLine("Your took the book:");
            Console.WriteLine($"  Name: {book.Name}\n" +
                              $"  Author: {book.Author}\n" +
                              $"  Id: {book.Id}\n\n"
                              );
        }


        // Method ReturnBook 
        public string ReturnBook(Library library, int id)
        {
            if (!IsInLibrary(library, id))
            {
                Book isInDel = library.delBooks.FirstOrDefault(x => x.Id == id);
                if (isInDel != null)
                {
                    library.GetBackBook(isInDel);
                    return "You succesfully returned the book\n";
                }
                return "The book is empty\n";
            }
            return "There is already such book in library! \nPlease give back the book, which you have taken!!!";
        }
    }
}
