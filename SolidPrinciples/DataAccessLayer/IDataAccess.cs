using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessEntities;

namespace DataAccessLayer
{
    public interface IDataAccess : IEmployeeDataAccess
    {
        
        void ModifyEmployees(IList<Employee> employees);
        void SaveEmployeeData(IList<Employee> employees);
    }
}
