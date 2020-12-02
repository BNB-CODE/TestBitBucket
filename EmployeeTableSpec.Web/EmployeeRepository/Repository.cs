using Employee.Service.DependentInterface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepository
{
    //using Employee.Service.Model;
    using Database.Model;
    public class Repository: IEmployeeRepository
    {
        private readonly AppDbContext _dbContext;

        public Repository(AppDbContext context)
        {
            _dbContext = context;

        }
        public Employee GetEmployee(int id)
        {
            return _dbContext.Employees.SingleOrDefault(x => x.Id == id);
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            var dt = _dbContext.Employees.ToList();
            IEnumerable<Employee> Data = new List<Employee>();
            if (dt.Count()>0)
            {
                Data = dt;
            }
            return Data;
        }
        public Employee Add(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return employee;
        }
        public Employee Update(Employee employee)
        {
            Employee Empobj = _dbContext.Employees.SingleOrDefault(x => x.Id == employee.Id);
            Empobj.Name = employee.Name;
            Empobj.Email = employee.Email;
            _dbContext.Employees.Update(Empobj);
            _dbContext.SaveChanges();
            return Empobj;
        }
        public Employee Delete(int id)
        {
            Employee Empobj = _dbContext.Employees.SingleOrDefault(x => x.Id == id);
            _dbContext.Employees.Remove(Empobj);
            _dbContext.SaveChanges();
            return Empobj;
        }
    }
}
