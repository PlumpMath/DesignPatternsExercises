using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class EmployeeOracleData : EmployeeData
    {
        private readonly IDisplayEmployee _displayEmployee;

        public EmployeeOracleData(IDisplayEmployee displayEmployee)
        {
            _displayEmployee = displayEmployee;
        }

        public override void DisplayEmployeeData()
        {
            //IDisplayEmployee displayEmployee = new DisplayEmployeeOracleData();
            _displayEmployee.DisplayEmployeeData();
        }
    }
}
