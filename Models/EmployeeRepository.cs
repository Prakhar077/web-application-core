using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationcore.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> Data()
        {
            return new List<Employee>()
            {
                new Employee() { EmpId = 101, EmpName = "Jaydip", EmpAddress = "Pune", PassportNo = "BD1392928", Age = 23 },
                new Employee() { EmpId = 102, EmpName = "Prova", EmpAddress = "Mumbai", PassportNo = "KDRP92928", Age = 22 },
                new Employee() { EmpId = 103, EmpName = "Smriti", EmpAddress = "Lucknow", PassportNo = "WGAP92928", Age = 24 },
                new Employee() { EmpId = 104, EmpName = "Sinchan", EmpAddress = "Hyderabad", PassportNo = "PPAY92928", Age = 21 },
                new Employee() { EmpId = 105, EmpName = "Kushal", EmpAddress = "Kolkata", PassportNo = "AKLT92928", Age = 22 },
            };
        }

        public List<Employee> GetAllEmployee()
        {
            return Data();
        }


        public Employee GetEmployeeById(int EmpId)
        {
            return Data().FirstOrDefault(e => e.EmpId == EmpId);
        }
    }
}
