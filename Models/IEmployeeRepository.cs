using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationcore.Models
{
     public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int EmpId);
        List<Employee> GetAllEmployee();
    }
}
