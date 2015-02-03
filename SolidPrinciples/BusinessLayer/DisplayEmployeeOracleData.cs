using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DisplayEmployeeOracleData : DisplayEmployee
    {
        private readonly IDataFormatter _dataFormatter;

        public override void DisplayEmployeeData()
        {
            //IDataFormatter dataFormatter = new OracleDataFormatter(new OracleDataAccess());
            string empData = _dataFormatter.FormatEmployeeData();
            Console.WriteLine("Displaying Employee Data for Oracle as below.");
            Console.WriteLine(empData);
        }

        public DisplayEmployeeOracleData(IDataFormatter dataFormatter)
        {
            _dataFormatter = dataFormatter;
        }
    }
}
