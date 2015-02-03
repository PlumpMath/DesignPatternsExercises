using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class SqlDataFormatter : DataFormatter
    {
        //private readonly IEmployeeDataAccess _dataAccess;

        //public SqlDataFormatter(IEmployeeDataAccess dataAccess)
        //{
        //    _dataAccess = dataAccess;
        //}

        public override string FormatEmployeeData()
        {
            IEmployeeDataAccess dataAccess = new SqlDataAccess();
            Console.WriteLine("Getting Employee Data...");
            var employeesList = dataAccess.GetEmployeeData();
            Console.WriteLine("Formatting the Employee details...");
            return string.Format("Employee Name of Employee ID {0} is {1}",
                employeesList[0].EmployeeId,
                employeesList[0].EmployeeName);
        }
    }
}
