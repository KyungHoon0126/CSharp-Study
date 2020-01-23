using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_base
{
    #region base_Ex_1
    //public class Computer
    //{
    //    bool powerOn;
    //    public void Book() { }
    //    public void Shutdown() { }
    //    public void Reset() { }
    //}

    //public class NoteBook : Computer
    //{
    //    bool fingerScan;
    //    public bool HasFingerScanDevice() { return fingerScan; }

    //    public void CloseLid()
    //    {
    //        base.Shutdown(); // base 예약어를 명시
    //    }
    //}
    #endregion

    #region base_Ex_2
    class Book
    {
        decimal isbn13;

        public Book(decimal isbn13)
        {
            this.isbn13 = isbn13;
        }
    }

    class EBook : Book
    {
        public EBook() : base(0)
        {

        }

        public EBook(decimal isbn) : base(isbn) // 또한 이렇게 값을 연계하는 것도 가능하다.
        {

        }
    }
    #endregion
}
