using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationcore.Models;

namespace WebApplicationcore.Controllers
{
    public class NetCoreController : Controller
    {
        /* public string Index()
         {
             return "Writing my own Index Action Method for this MVC Controller";
         }*/
        /*public JsonResult Index()
        {
            EmployeeRepository repository = new EmployeeRepository();
            List<Employee> allEmpDetails = repository.GetAllEmployee();
            return Json(allEmpDetails);
        }
        public JsonResult GetEmployeeDetails(int Id)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee empDetails = repository.GetEmployeeById(Id);
            return Json(empDetails);
        }*/

        private readonly IEmployeeRepository _repository = null;
        public NetCoreController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public JsonResult Index()
        {
            List<Employee> allEmpDetails = _repository.GetAllEmployee();
            return Json(allEmpDetails);
        }

        public JsonResult GetEmployeeDetails(int Id)
        {
            Employee empInfo = _repository.GetEmployeeById(Id);
            return Json(empInfo);
        }
    }

}
