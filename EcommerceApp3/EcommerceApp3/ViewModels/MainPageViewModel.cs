using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using EcommerceApp3.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace EcommerceApp3.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
        {            
            LogInCommand = new Command(LogInCommandHandler);
            SignUpCommand = new Command(SignUpCommandHandler);
            _navigationService = navigationService;
        }
        public ICommand LogInCommand { get; set; }
        public ICommand SignUpCommand { get; set; }

        private async void LogInCommandHandler()
        {
            await _navigationService.NavigateAsync(nameof(LoginPage));
             
        }
        
        private async void SignUpCommandHandler()
        {
            await _navigationService.NavigateAsync(nameof(RegisterationPage));
        }        
    }
}
