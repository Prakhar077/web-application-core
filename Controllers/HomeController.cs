using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationcore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Writing my own Index Action Method for this MVC Controller - Prakhar";
        }
    }
}
