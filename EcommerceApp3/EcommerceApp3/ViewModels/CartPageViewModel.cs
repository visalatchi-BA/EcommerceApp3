using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using EcommerceApp3.Model;
using EcommerceApp3.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;
using static SQLite.SQLite3;

namespace EcommerceApp3.ViewModels
{
    public class CartPageViewModel : BindableBase , INavigatedAware
    {
        private ObservableRangeCollection<Product> _content;
        private Product _seperateDetails;
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogService;

        public CartPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) 
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
            LogoutCommand = new Command(LogoutCommandHandler);
        }
        public ObservableRangeCollection<Product> Content
        {
            get
            {
                return _content;
            }
            set
            {
                SetProperty(ref _content, value);
            }
        }

        public Product SeperateDetails
        {
            get
            {
                return _seperateDetails;
            }
            set
            {
                SetProperty(ref _seperateDetails, value);
               
            }
        }
        public ICommand LogoutCommand { get;  set; }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if(parameters.TryGetValue<Product>("TappedData", out var product))
            {
                SeperateDetails = product;
            }          
            
           
        }
        private async void LogoutCommandHandler()
        {
            await _pageDialogService.DisplayAlertAsync("LOGOUT","Are you sure to Logout?","Ok");
           
            await _navigationService.NavigateAsync(nameof(FirstPage));
        }
    }
}
