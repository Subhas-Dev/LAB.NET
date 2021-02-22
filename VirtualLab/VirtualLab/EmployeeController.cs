using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VirtualLab.BusinessObjects;
namespace VirtualLab
{
    public class EmployeeController
    {
        public List<Employee> EmpList = null;

        public EmployeeController()
        {
            EmpList = new List<Employee>();
        }

        public void AddEmployee(Employee Emp)
        {
            EmpList.Add(Emp);
        }

        public void RemoveEmployedd(Employee Emp)
        {
            EmpList.Remove(Emp);
        }
    }
}