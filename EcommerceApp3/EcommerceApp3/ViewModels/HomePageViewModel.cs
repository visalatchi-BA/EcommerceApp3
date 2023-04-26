using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EcommerceApp3.Interface;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using static EcommerceApp3.Model.ApiProduct;

namespace EcommerceApp3.ViewModels
{
    //public class HomePageViewModel : ViewModelBase
    //{
    //    private readonly INavigationService _navigationService;
    //    private readonly IRandomApiService _randomApiService;
      

        

    //    public HomePageViewModel(IRandomApiService randomApiService, INavigationService navigationService)
    //    { 
        
    //        _randomApiService = randomApiService;
            //var list = _randomApiService.GetRandomApiAsync();
            ////ObservableCollection<Product> products = new ObservableCollection<Product>(list);

            
            //DataList = new List<Product>((IEnumerable<Product>)list);
            
       // }
        //public ObservableCollection<Product> DataList
        //{
        //    get { return _dataList; }
        //    set { SetProperty(ref _dataList, value); }
        //public List<Product> DataList
        //{
        //    get
        //    {
        //        return _dataList;
        //    }
        //    set
        //    {
        //        SetProperty(ref _dataList, value);
        //    }
        //}
    }
//}
