using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class BoardMember : Employee
    {
        public void Resign()
        {
            Console.WriteLine("I Ressgined From Company...");
            //throw new NotImplementedException();
        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.Resigned)
                base.OnEmployeeLayOff(e);
        }
    }
}
