using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
            //throw new NotImplementedException();
        }
        public int EmployeeID { get; set; }

        public DateTime BirthDate
        {
            get => BirthDate;
            set
            {
                BirthDate = value;
                int age_year = DateTime.Now.Year - value.Year;
                if (age_year > 60)
                {
                    //notify sub
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs());
                }
            }
        }
        public int VacationStock
        {
            get => VacationStock;
            set
            {
                VacationStock = value;
                if (VacationStock < 0)
                {
                    //Notify subs
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs());
                }
            }
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            int numOfDays = To.Day - From.Day;
            if (numOfDays <= VacationStock) return true;
            return false;
            //throw new NotImplementedException();
        }
        public void EndOfYearOperation()
        {
            if (BirthDate.Year > DateTime.Now.Year )
                Console.WriteLine("Thanks For Working With Us We Will Miss You....");
            //throw new NotImplementedException();
        }
    }
}
