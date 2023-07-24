using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationcore.Models;

namespace WebApplicationcore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct ip = null;
        public ProductController(IProduct pp)
        {
            ip = pp;
        }
        public JsonResult Index()
        {
            List<Product1> lp =  ip.GetAllProduct();
               return Json(lp);
        }

        public JsonResult ABC(int id)
        {
            Product1 pr = ip.GetProductById(id);
            return Json(pr);
        }

    }
}
