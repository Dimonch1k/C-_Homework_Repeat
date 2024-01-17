using System.Runtime.InteropServices;

namespace MyLibrary
{
    class LibraryProgram
    {
        public static void Main(string[] args)
        {
            Library library = new Library();
            
            Visitor<string, int> visitor = new Visitor<string, int>() {
                Name = "Juriy",
                Age = 16 
            };

            CreateBooks(library);


            Console.WriteLine(visitor.TakeBook(library, InputId("Input the id of the book you want to take: ")));
            Console.WriteLine(visitor.ReturnBook(library, InputId("Input the id of the book you want to return: ")));
        }

        private static void CreateBooks(Library library) // User create 4 books
        {
            Console.WriteLine("\nAdd 4 books to the Library.");
            for (int i = 0; i < 4; i++)
            {
                Book book = new Book(); // Create object

                Console.Write($"  Input {i + 1} book's name: ");
                book.Name = Console.ReadLine(); // User input name

                Console.Write($"  Input {i + 1} book's id: ");
                book.Id = Int32.Parse(Console.ReadLine()); // User input integer

                Console.Write($"  Input the author for {i + 1} book: ");
                book.Author = Console.ReadLine(); // User input author
                Console.WriteLine("\n"); // Skip two lines

                library.AddBook(book); // Add book to the list
            }
        }

        private static int InputId(string text)
        {
            PrintText(text);
            return Int32.Parse(Console.ReadLine());
        }
        private static void PrintText(string text)
        {
            Console.Write(text);
        }
    }
}