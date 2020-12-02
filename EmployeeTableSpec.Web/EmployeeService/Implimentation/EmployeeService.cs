
using Employee.Service.DependentInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee.Service
{
    //using Service.Model;
    using Database.Model;
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _EmployeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _EmployeeRepository = employeeRepository;
        }
        public Employee GetRecentEmployee()
        {
            IEnumerable<Employee> obj = _EmployeeRepository.GetAllEmployees();
            Employee Employeeobj=obj.OrderBy(x => x.DOJ).FirstOrDefault();
            return Employeeobj;
        }
    }
}
