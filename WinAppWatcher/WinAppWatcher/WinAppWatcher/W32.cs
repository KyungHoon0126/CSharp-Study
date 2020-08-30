using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWatcher
{
    public class W32
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, string lpString, int cch);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out Int32 lpdwProcessId);

        public static Int32 GetWindowProcessID(IntPtr hWnd)
        {
            Int32 pid;
            GetWindowThreadProcessId(hWnd, out pid);
            return pid;
        }

        public static IntPtr getForegroundWindow()
        {
            return GetForegroundWindow();
        }

        public static string ActiveAppTitle()
        {
            IntPtr hWnd = getForegroundWindow();
            if (hWnd.Equals(IntPtr.Zero))
            {
                return "";
            }
            string lpText = new string((char)0, 100);
            int intLength = GetWindowText(hWnd, lpText, lpText.Length);
            if((intLength <= 0) || (intLength > lpText.Length))
            {
                return "unknown";
            }
            return lpText.Trim();
        }

        public W32()
        {

        }
    }
}
