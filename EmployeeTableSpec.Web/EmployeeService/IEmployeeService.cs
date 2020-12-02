using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Service
{
    //using Service.Model;
    using Database.Model;
    public interface IEmployeeService
    {
        Employee GetRecentEmployee();
    }
}
