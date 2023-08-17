using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    public enum LayOffCause
    {
        retiring, usedAll_vacationStock, AchievedTarget , Resigned
    }

    internal class EmployeeLayOffEventArgs:EventArgs
    {

        public LayOffCause Cause { get; set; }
    }
}
