using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WinAppWatcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Windows.Forms.Timer timer1;
        private NotifyIcon notifyIcon1;

        public static string appName, preValue;
        public static System.Collections.Stack applnames;
        public static Hashtable applhash;
        public static DateTime applfocustime;
        public static string appltitle;
        public static MainWindow mainWindow1;
        public static string tempstr;
        public TimeSpan applfocusinterval;
        public DateTime logintime;

        public MainWindow()
        {
            InitializeComponent();
            applnames = new Stack();
            applhash = new Hashtable();
            mainWindow1 = new MainWindow();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += Timer1_Tick;

            Loaded += MainWindow_Loaded;
            notifyIcon1.Click += NotifyIcon1_Click;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            mainWindow1.Visibility = Visibility.Hidden;
            notifyIcon1.Text = "Application Watcher is in INvisible Mode";
            logintime = DateTime.Now;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                bool isNewAppl = false;
                IntPtr hWnd = W32.getForegroundWindow();
                Int32 pid = W32.GetWindowProcessID(hWnd);
                Process p = Process.GetProcessById(pid);
                appName = p.ProcessName;
                appltitle = W32.ActiveAppTitle().Trim().Replace("\0", "");

                if(!applnames.Contains(appltitle + appName))
                {
                    applnames.Push(appltitle + appName);
                    applhash.Add(appltitle + appName, 0);
                    isNewAppl = true;
                }

                if(preValue != (appltitle + appName))
                {
                    IDictionaryEnumerator en = applhash.GetEnumerator();
                    applfocusinterval = DateTime.Now.Subtract(applfocustime);

                    while (en.MoveNext())
                    {
                        if(en.Key.ToString() == preValue)
                        {
                            double prevseconds = Convert.ToDouble(en.Value);
                            applhash.Remove(preValue);
                            applhash.Add(preValue, (applfocusinterval.TotalSeconds + prevseconds));
                            break;
                        }
                    }
                    preValue = appltitle + appName;
                    applfocustime = DateTime.Now;
                }
                if(isNewAppl)
                {
                    applfocustime = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + " : " + ex.StackTrace);
            }
        }

        private void ShowDetailSinIE()
        {
            // DB
        }

        private void TestFocusedChanged()
        {
            try
            {
                if(applhash.Count == 1)
                {
                    IDictionaryEnumerator en = applhash.GetEnumerator();
                    applfocusinterval = DateTime.Now.Subtract(applfocustime);

                    while(en.MoveNext())
                    {
                        if(en.Key.ToString() == appltitle + appName)
                        {
                            applhash.Remove(appltitle + appName);
                            applhash.Add(appltitle + appName, applfocusinterval.TotalSeconds);
                            break;
                        }
                    }
                }
            }   
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void BindGrid()
        {
            SaveandShowDetails();
            // dataGrid1.DataContext = ;
        }

        private void SaveandShowDetails()
        {
            try
            {
                TestFocusedChanged();
                // DB 
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainWindow1.Visibility == Visibility.Visible)
                {
                    mainWindow1.Visibility = Visibility.Hidden;
                    notifyIcon1.Text = "Application Watcher is in Invisible Mode";
                }
                else
                {
                    mainWindow1.Visibility = Visibility.Visible;
                    mainWindow1.Focus();
                    mainWindow1.WindowState = WindowState.Normal;
                    notifyIcon1.Text = "Application Watcher is in Visible Mode";
                    BindGrid();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void menuItem2_Click(object sender, RoutedEventArgs e)
        {
            BindGrid();
        }

        private void menuItem3_Click(object sender, RoutedEventArgs e)
        {
            SaveandShowDetails();
            TimeSpan timeinterval = DateTime.Now.Subtract(logintime);
            
            // DB
        }
    }
}
