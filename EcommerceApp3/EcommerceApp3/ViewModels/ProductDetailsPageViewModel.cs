using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EcommerceApp3.Interface;
using EcommerceApp3.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.CommunityToolkit.ObjectModel;

namespace EcommerceApp3.ViewModels
{
    public class ProductDetailsPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IProductService _productService;

        public ProductDetailsPageViewModel(INavigationService navigationService, IProductService productService)
        {
            _navigationService = navigationService;
            _productService = productService;
            CartCommand = new DelegateCommand<Product>(CartCommandHandler);
        }

        public DelegateCommand<Product> CartCommand { get; set; }
        public ObservableRangeCollection<Product> Products { get; set; } = new ObservableRangeCollection<Product>();
        private async void CartCommandHandler(Product product) 
        {
            var list = Products.Where(x => x == product);
            await _navigationService.NavigateAsync("CartPage",new NavigationParameters 
            {
                {"TappedData", product}
            });
        }

        public override void OnNavigatedTo(INavigationParameters parameters)             
        {
            base.OnNavigatedTo(parameters);
            Products.AddRange(_productService.GetProductsList());
        }
    }
}
