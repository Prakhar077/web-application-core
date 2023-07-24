using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationcore.Models
{
    public interface IProduct
    {
        List<Product1> GetAllProduct();
        Product1 GetProductById(int pId);
    }
}
