using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingIsEnabled
{
     class LoginViewModel
    {
        private string _loginID;
        public string LoginID
        {
            get
            {
                return _loginID;
            }
            set
            {
                _loginID = value;
                OnPropertyUpdate("LoginID");
            }
        }

        private string _loginPassword;
        public string LoginPassword

        {
            get
            {
                return _loginPassword;
            }
            set
            {
                _loginPassword = value;
                OnPropertyUpdate("LoginPassword");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyUpdate(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
