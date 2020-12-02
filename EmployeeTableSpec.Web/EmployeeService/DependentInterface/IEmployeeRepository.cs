
using System;
using System.Collections.Generic;
using System.Text;


namespace Employee.Service.DependentInterface
{
    //using Service.Model;
    using Database.Model;
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        Employee Delete(int id);
    }
}
