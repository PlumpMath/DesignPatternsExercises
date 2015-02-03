using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessEntities;

namespace BusinessLogicLayer
{
    public class EmployeeSqlData : EmployeeData
    {
        private readonly IDisplayEmployee _displayEmployee;

        public EmployeeSqlData(IDisplayEmployee displayEmployee)
        {
            _displayEmployee = displayEmployee;
        }
        
        public override void DisplayEmployeeData()
        {
            _displayEmployee.DisplayEmployeeData();
            //new DisplayEmployeeSqlData().DisplayEmployeeData();      
        }
    }
}
