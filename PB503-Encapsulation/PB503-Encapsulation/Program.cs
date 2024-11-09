namespace PB503_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 =new Book (1,"Yüzyıllık yalnızlık", 12.5, "roman");
            Book book2 = new Book(2, "Kizila boyali saclar", 14.7, "kurgu");
            Book book3 = new Book(3, "Aksam gunesi", 26.3, "dram");
            Book book4 = new Book(4, "Paris'te bir aksam", 21.9, "romantik");
            Book book5 = new Book(5, "Aksam gezmesi", 6.8, "dram");

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook (book2);
            library.AddBook (book3);
            library.AddBook (book4);
            library.AddBook (book5);

            //foreach (var item in library.books)
            //{
            //    Console.WriteLine(item.Name);
            //}

            Book wantedbook = library.GetBookById(1);
            Console.WriteLine(wantedbook.Name);

            Book[] wantedbook2 = library.GetBooksByName("aksam");

            foreach (var item in wantedbook2)
            {
                Console.WriteLine(item.Name);
            }

            Book[] wantedbook3 = library.GetFilteredBooks("dram");
            foreach (var item in wantedbook3)
            {
                Console.WriteLine(item.Name);
            }

            Book[] wantedbook4 = library.GetFilteredBooksForPrice(10.0, 20.0);
            foreach (var book in wantedbook4)
            {
                Console.WriteLine(book.Name);
            }
        }
    }
}
