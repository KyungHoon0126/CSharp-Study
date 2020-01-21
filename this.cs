using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_this
{
    #region this_Ex_1
    //class Book
    //{
    //    decimal _isbn;
    //    public decimal ISBN
    //    {
    //        get { return this._isbn; }
    //    }

    //    public Book(decimal isbn)
    //    {
    //        this._isbn = isbn;
    //    }

    //    public decimal GetISBN()
    //    {
    //        return this.ISBN;
    //    }

    //    public void Sell()
    //    {
    //        Console.WriteLine("Sell : " + this.GetISBN());
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Book book = new Book(978126548);
    //        book.Sell();
    //    }
    //}
    #endregion

    #region this_Ex_2
    //class Book
    //{
    //    public string title;
    //    public decimal isbn13;
    //    public string author;

    //    public Book(string title) : this(title, 0)
    //    {

    //    }

    //    public Book(string title, decimal isbn13) : this(title, isbn13, string.Empty)
    //    {

    //    }

    //    // 초기화 코드를 하나의 생성자에서 처리
    //    public Book(string title, decimal isbn13, string author)
    //    {
    //        this.title = title;
    //        this.isbn13 = isbn13;
    //        this.author = author;
    //    }

    //    public Book() : this(string.Empty, 0, string.Empty)
    //    {

    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Book book = new Book("김경훈", 5456238, "김경훈");
    //        Console.WriteLine(book.title + " " + book.isbn13 + " " + book.author);
    //    }
    //}
    #endregion

    #region this_Ex_3
    class Book
    {
        string title; // 인스턴스 필드
        static int count; // 정적 필드

        public Book(string title) // 인스턴스 생성자
        {
            this.title = title; // this로 인스턴스 필드 식별 가능
            this.Open(); // this로 인스턴스 메서드 식별 가능
            Increment(); // 정적 메소드 사용 가능
        }

        void Open()
        {
            Console.WriteLine(this.title); // 인스턴스 멤버 사용 가능
            Console.WriteLine(count); // 정적 멤버 사용 가능
        }

        public void Close()
        {
            Console.WriteLine(this.title + " 책을 덮는다.");
        }

        static void Increment() // 정적 메서드
        {
            count++; // 정적 필드 사용 가능
                     // 정적 메서드에는 this가 없으므로 인스턴스 멤버 사용 불가능
        }

        public class Program
        {
            static void Main(string[] args)
            {
                Book book = new Book("김경훈");
                book.Close();
            }
        }
    }
    #endregion
}
