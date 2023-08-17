using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members; public void AddMember(Employee E)
        {
            //throw new NotImplementedException()
            Members.Add(E);
            ///Try Register for EmployeeLayOff Event Here
            E.EmployeeLayOff += this.RemoveMember;
        }
        ///CallBackMethod public 
        void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee emp && emp.VacationStock < 0)
            {
                Members.Remove(emp);
            }
            //throw new NotImplementedException();
            ///Employee Will not be removed from the Club if Age>60 ///Employee will be removed from Club if Vacation Stock < 0
        }
    }
}
