using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using EcommerceApp3.Model;

namespace EcommerceApp3.Interface
{
    public interface IProductService
    {
        List<Product> GetProductsList();   
    }
}
