using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Book
    {
        private String bookCode;
        private String bookTile;
        private int bookshelves;
        private int discount;

        public Book(String bc, String bt)
        {
            bookCode = bc;
            bookTile = bt;
        }

        public Book(String bc, String bt, int bs, int dc)
        {
            bookCode = bc;
            bookTile = bt;
            bookshelves = bs;
            discount = dc;
        }

        // Get, Set bookCode
        public void SetBookCode(String bc)
        {
            bookCode = bc;
        }

        public String GetBookCode()
        {
            return bookCode;
        }


        // Get, Set bookTitle
        public void SetBookTitle(String s)
        {
            bookTile = s;
        }

        public String GetBookTitle()
        {
            return bookTile;
        }

        // Get, Set bookshelves
        public void SetBookshelves(int bs)
        {
            bookshelves = bs;
        }

        public int GetBookshelves()
        {
            return bookshelves;
        }

        // Get, Set discount
        public void SetDiscount(int dc)
        {
            discount = dc;
        }

        public int GetDiscount()
        {
            return discount;
        }

        public int PriceOfABook()
        {
            return bookshelves - discount;
        }
    }
}
