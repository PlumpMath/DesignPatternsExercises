using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DisplayEmployeeSqlData : DisplayEmployee
    {
        private readonly IDataFormatter _dataFormatter;

        public override void DisplayEmployeeData()
        {
            //IDataFormatter dataFormatter = new SqlDataFormatter();
            string empData = _dataFormatter.FormatEmployeeData();
            Console.WriteLine("Displaying the Employee details...");
            Console.WriteLine(empData);
        }

        public DisplayEmployeeSqlData(IDataFormatter dataFormatter)
        {
            _dataFormatter = dataFormatter;
        }
    }
}
