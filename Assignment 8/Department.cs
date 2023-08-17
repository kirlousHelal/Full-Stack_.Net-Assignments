using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff;
        public void AddStaff(Employee E)
        {
            //throw new NotImplementedException();
            Staff.Add(E);
            ///Try Register for EmployeeLayOff Event Here
            E.EmployeeLayOff += this.RemoveStaff;
        }
        ///CallBackMethod
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee emp)
            {
                Staff.Remove(emp);
            }
            //throw new NotImplementedException();
        }
    }
}
