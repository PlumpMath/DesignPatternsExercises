using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessEntities;

namespace DataAccessLayer
{
    public class OracleDataAccess : IEmployeeDataAccess
    {
        public IList<Employee> GetEmployeeData()
        {
            var employees = new Employee[1];
            employees[0] = new Employee { EmployeeId = "Ora-123", EmployeeName = "Benjamin Franklin", Designation = "Manager" };
            return new List<Employee>(employees);
        }               
    }
}
