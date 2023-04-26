using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EcommerceApp3.Interface;
using Flurl.Http;
using Prism.AppModel;
using static EcommerceApp3.Model.ApiProduct;

namespace EcommerceApp3.Services
{
    public class RandomApiService : IRandomApiService

    {
      

        //public async Task<List<Product>>GetRandomApiAsync()
        //{
        //    string url = "https://dummyjson.com/products";
        //    var apidata = await url.GetJsonAsync<Root>();
        //    var dataList = new List<Product>(apidata.Products);

        //    return dataList;

        //}
    }
}
