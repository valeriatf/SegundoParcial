using System;
using System.Collections.Generic;
using System.Text;

namespace App2.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    using Service;
    using Xamarin.Forms;
    using Models;
    using View;

    public class LoginViewModel : BaseViewModel
    {
        #region Attributes
        string notes;
        string password;
        bool isrunning;
        bool isenable;
        #endregion
        #region Properties
        public string Notes
        {
            get
            {
                return this.notes;
            }
            set
            {
                SetValue(ref this.notes, value);
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
            if (string.IsNullOrEmpty(Notes))
            {
                await App.Current.MainPage.DisplayAlert("Note empty",
                                                    "Please input your Note",
                                                    "Accept");
                return;
            }


            IsRunning = true;
        }
        #endregion
    }
}
