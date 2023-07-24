using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationcore.Models;

namespace WebApplicationcore.Models
{
    public class ProductRes : IProduct
    {


        public List<Models.Product1> Data()
        {
            return new List<Product1>()
            {
                new Product1() {pId = 101, pName = "Jaydip", pAddress = "Pune" },
                new Product1() {pId = 102, pName = "Prova", pAddress = "Mumbai"},
                new Product1() { pId = 103, pName = "Smriti", pAddress = "Lucknow"},
                new Product1() { pId = 104, pName = "Sinchan", pAddress = "Hyderabad"},
                new Product1() { pId = 105, pName = "Kushal", pAddress = "Kolkata" },
            };
        }

        public Product1 GetProductById(int pId)
        {
            return Data().SingleOrDefault(p => p.pId == pId);
        }
        public List<Product1> GetAllProduct()
        {
            return Data();
        }
     

       

       

       
    }
}
