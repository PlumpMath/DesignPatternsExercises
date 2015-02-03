using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessEntities;

namespace DataAccessLayer
{
    public abstract class DataAccess : IDataAccess
    {
        public abstract IList<Employee> GetEmployeeData();

        #region IDataAccess Members
        
        public abstract void ModifyEmployees(IList<Employee> employees);
        public abstract void SaveEmployeeData(IList<Employee> employees);
        
        #endregion
    }
}
