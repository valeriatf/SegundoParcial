using System;
using System.Collections.Generic;
using System.Text;

namespace App2.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Attributes
        string email;
        string password;
        bool isrunning;
        bool isenable;
        #endregion
        #region Properties
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                SetValue(ref this.email, value);
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                SetValue(ref this.password, value);
            }
        }
        public bool IsRunning
        {
            get
            {
                return this.isrunning;
            }
            set
            {
                SetValue(ref this.isrunning, value);
            }
        }
        public bool IsEnable
        {
            get
            {
                return this.isenable;
            }
            set
            {
                SetValue(ref this.isenable, value);
            }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(cmdLogin);
            }
        }

        private async void cmdLogin()
        {
            if (string.IsNullOrEmpty(Email))
            {
                await App.Current.MainPage.DisplayAlert("Email empty",
                                                    "Please input email",
                                                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Password empty",
                                                        "Please entry password", "Accept");
                return;
            }

            IsRunning = true;
        }
        #endregion
    }
}
