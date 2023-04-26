using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using EcommerceApp3.Helper;
using EcommerceApp3.Interface;
using EcommerceApp3.Model;
using Flurl.Http;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace EcommerceApp3.ViewModels
{
    public class RegisterationPageViewModel : ViewModelBase

    {
        private string _emailID;
        private string _userName;
        private string _password;
        private string _phoneNumber;
        private string _confirmPassword;

       
        private readonly INavigationService _navigationService;

        public RegisterationPageViewModel(INavigationService navigationService)
        {

            RegisterCommand = new Command(RegisterCommandHandler);

            
            _navigationService = navigationService;
        }
        public UserDB UserDB = new UserDB();
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                SetProperty(ref _userName, value);

            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                SetProperty(ref _password, value);
            }
        }

        public string ConfirmPassword
        {
            get
            {
                return _confirmPassword;
            }
            set
            {
                SetProperty(ref _confirmPassword, value);
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                SetProperty(ref _phoneNumber, value);
            }
        }
        public string EmailID
        {
            get
            {
                return _emailID;
            }
            set
            {
                SetProperty(ref _emailID, value);
            }
        }


        public Command RegisterCommand { get; set; }
        private async void RegisterCommandHandler()
        {
            
            var user = new User { UserName = UserName, Password = Password, Email = EmailID, PhoneNumber = PhoneNumber };
            UserDB.AddUser(user);
           
            await _navigationService.GoBackAsync();
        }


         



    }
}
