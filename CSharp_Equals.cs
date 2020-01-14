using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Equals
{
    class Book
    {
        decimal _isbn;

        public Book(decimal isbn)
        {
            _isbn = isbn;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(9788998139018);
            Book book2 = new Book(9788998139018);

            Console.WriteLine(book1.Equals(book2));

            // False

            string txt1 = new string(new char[] { 't', 'e', 'x', 't' });
            string txt2 = new string(new char[] { 't', 'e', 'x', 't' });

            Console.WriteLine(txt1.Equals(txt2));

            // True
        }
    }
}
