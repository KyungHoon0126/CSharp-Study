using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingIsEnabled
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginViewModel loginViewModel = new LoginViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += OnLoaded;
            this.LoginBtn.Click += LoginBtn_Click;
            this.DataContext = new LoginViewModel();
        }
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            Keyboard.Focus(this.ID);
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            loginViewModel.LoginID = this.ID.Text;
            loginViewModel.LoginPassword = this.Password.Text;

            if (string.IsNullOrEmpty(loginViewModel.LoginID))
            {
                MessageBox.Show("아이디를 입력해 주세요.");
                Keyboard.Focus(this.ID);
                return;
            }

            if (string.IsNullOrEmpty(loginViewModel.LoginPassword))
            {
                MessageBox.Show("비밀번호를 입력해 주세요.");
                Keyboard.Focus(this.Password);
                return;
            }
            doLogin();
        }

        private bool doLogin()
        {
            MessageBox.Show(string.Format("아이디 = {0}, 비밀번호 = {1}", loginViewModel.LoginID, loginViewModel.LoginPassword));
            return true;
        }
    }
}
