using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Input;
using EcommerceApp3.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace EcommerceApp3.ViewModels
{
    public class FirstPageViewModel :  ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public FirstPageViewModel(INavigationService navigationService)
           

        {
          
            StartedCommand = new Command(StartedCommandHandler);
            _navigationService = navigationService;
           
        }
        public ICommand StartedCommand { get; set; }
        private async void  StartedCommandHandler()
        {
            await _navigationService.NavigateAsync(nameof(MainPage));
        }

    }
}
