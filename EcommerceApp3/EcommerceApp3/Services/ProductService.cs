using System.Collections.Generic;
using System.Collections.ObjectModel;
using EcommerceApp3.Interface;
using EcommerceApp3.Model;

namespace EcommerceApp3.Services
{
    public  class ProductService :IProductService
    {
        public List<Product> GetProductsList()
        {
            return new List<Product>()
            {
                new Product() { ProductName="Mobile", Description="Sport (Coral Green, 2GB RAM, 32GB Storage) | 2GHz Octa-core Helio G25 Processor | 5000 mAh Battery", Price="Rs.9000",ImageUrl="Redmi.jpg"},
                new Product() { ProductName="Laptop", Description="ASUS VivoBook 15 (2021), 15.6-inch (39.62 cm) HD, Dual Core Intel Celeron N4020, Thin and Light Laptop (4GB RAM/256GB", Price="Rs.4000",ImageUrl="laptopp.jpg"},
                new Product() { ProductName="Sports Shoe",Description="AVANT Men's Ultra Light Running and Training Shoes", Price="Rs.1000",ImageUrl="shoee.jpg"},
                new Product() { ProductName="Wallet", Description="Oliver Black RFID Blocking Leather Wallet for Men", Price="Rs.500",ImageUrl="wallet.png"},
                new Product() { ProductName="Home Decor", Description="Polyresin Buddha Idol Decorative Showpiece Little Baby Monk", Price="Rs.400",ImageUrl="buddhaa.jpg"},
                new Product() { ProductName="Watches", Description="Fastrack New Reflex Hello|BT Calling|1.69” HD Display|50+ Sports Modes|100+", Price="Rs.1000",ImageUrl="Watches.jpg"}
            };   
   

        }       
    }
}
