using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReader_ReadLine
{
    class FileStream_StreamReader
    {
        static void Main(string[] args)
        {
            // 파일 쓰기

            FileStream tstFs = new FileStream("test2.txt", FileMode.Create, FileAccess.Write);

            byte[] buff = Encoding.ASCII.GetBytes("FileStream_Pratice");

            tstFs.Write(buff, 0, buff.Length);
            Console.WriteLine("FileStream 쓰기 완료.");

            tstFs.Seek(0, SeekOrigin.Begin);

            buff = new byte[tstFs.Length];

            tstFs.Read(buff, 0, (Convert.ToInt32(tstFs.Length)));
            Console.WriteLine("FileStream 읽기 : " + Encoding.ASCII.GetString(buff));


            // 파일 읽기

            FileStream fs = new FileStream("C:\\Users\\user\\source\\repos\\StreamReader_ReadLine\\StreamReader_ReadLine\\bin\\Debug\\test2.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            string tmpstring;

            while ((tmpstring = sr.ReadLine()) != null)
            {
                Console.WriteLine("한 라인 내용 : " + tmpstring);
            }

            sr.Close();
            fs.Close();
        }
    }
}
