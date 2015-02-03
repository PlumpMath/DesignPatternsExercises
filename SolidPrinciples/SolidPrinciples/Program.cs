using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLogicLayer;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeData employeeData = new EmployeeSqlData(new DisplayEmployeeSqlData(new OracleDataFormatter()));
            employeeData.DisplayEmployeeData();
            Console.ReadKey();
        }
    }
}
