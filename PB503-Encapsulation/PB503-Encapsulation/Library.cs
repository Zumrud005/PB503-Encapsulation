using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Encapsulation
{
    public class Library
    {
        public Book[] books=Array.Empty<Book>();

        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length+1);
            books[books.Length-1]=book;
        }


        public Book GetBookById(int id)
        {
            foreach (var book in books)
            {
                 if (book.Id == id)
                 {
                    return book;
                 }
                
            }
            return null;
        }


        public Book GetBookByName(string name)
        {
            foreach (var book in books)
            {
                if (book.Name == name)
                {
                    return book;
                }
            }
            return null;
        }


        public Book[] GetBooksByName(string name)
        {

            Book[] wantedbook=new Book[0];
            foreach (var book in books)
            {
                if (book.Name.ToLower().Contains(name.ToLower()))
                {
                   Array.Resize(ref wantedbook, wantedbook.Length+1);
                   wantedbook[wantedbook.Length-1]=book;

                }
            }
            return wantedbook;
        }

        public Book[] GetFilteredBooks (string value)
        {
            Book[] filtiredbooks = new Book[0];
            foreach (var book in books)
            {
                if (book.Genre == value)
                {
                    Array.Resize (ref filtiredbooks, filtiredbooks.Length+1);
                    filtiredbooks[filtiredbooks.Length-1]=book;

                }
            }
            return filtiredbooks;
        }

        public Book[] GetFilteredBooksForPrice(double minPrice, double maxPrice)
        {
            Book[] filteredprice= new Book[0];
            foreach (var book in books)
            {
                if(book.Price>minPrice && book.Price < maxPrice)
                {
                    Array.Resize(ref filteredprice, filteredprice.Length+1);
                    filteredprice[filteredprice.Length-1]=book;
                }
            }
            return filteredprice;
        }

    }
}
