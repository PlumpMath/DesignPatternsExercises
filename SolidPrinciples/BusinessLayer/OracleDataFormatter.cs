using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class OracleDataFormatter : DataFormatter
    {
        //private readonly IEmployeeDataAccess _dataAccess;

        //public OracleDataFormatter(IEmployeeDataAccess dataAccess)
        //{
        //    _dataAccess = dataAccess;
        //}

        public override string FormatEmployeeData()
        {
            IEmployeeDataAccess dataAccess = new OracleDataAccess();
            Console.WriteLine("Getting Employee Data...");
            var employeesList = dataAccess.GetEmployeeData();
            Console.WriteLine("Formatting the Employee details...");
            return string.Format("Employee Name of Employee ID {0} is {1} and Designation of the Employee is {2}",
                employeesList[0].EmployeeId,
                employeesList[0].EmployeeName,
                employeesList[0].Designation);
        }
    }
}
