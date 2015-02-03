using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessEntities;

namespace DataAccessLayer
{
    public interface IEmployeeDataAccess
    {
        IList<Employee> GetEmployeeData();
    }
}
