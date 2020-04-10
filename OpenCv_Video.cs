using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace OpenCV_Pratice
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoCapture video = new VideoCapture(0);
            Mat frame = new Mat();

            while (Cv2.WaitKey(33) != 'q')
            {
                video.Read(frame);
                Cv2.ImShow("KyungHoon", frame);
            }

            frame.Dispose();
            video.Release();
            Cv2.DestroyAllWindows();
        }
    }
}
