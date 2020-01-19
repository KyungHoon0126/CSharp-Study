using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_GetHashCode
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
            short n1 = 256;
            short n2 = 32750;
            short n3 = 256;

            Console.WriteLine(n1.GetHashCode());
            Console.WriteLine(n2.GetHashCode());
            Console.WriteLine(n3.GetHashCode());

            Book book1 = new Book(9788998139018);
            Book book2 = new Book(9788998139018);

            Console.WriteLine(book1.GetHashCode()); 
            Console.WriteLine(book2.GetHashCode());
        }
    }
}
