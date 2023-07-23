using System;
using System.Reflection;


namespace Assignment_2
{
    enum Gender
    {
        M, F
    }
    enum Flag
    {
        guest, Developer, secretary, DBA, full_permissions
    }

    struct HiringDate
    {
        internal int day;
        internal int month;
        internal int year;

        public void readDate()
        {
            Console.Write("Please Enter The Day: ");
            this.day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter The Month: ");
            this.month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter The Year: ");
            this.year = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            string date = @$"The Hiring Date is {day}/{month}/{year}";
            return date;
        }
    }

    struct Employee
    {

        #region Declaration

        int ID;
        Flag security_level;
        int salary;
        HiringDate hire_date;
        Gender gender;
        #endregion

        #region Setter

        public void setID(int ID) { this.ID = ID; }
        public void setSecurity_level(Flag security_level) { this.security_level = security_level; }
        public void setSalary(int salary) { this.salary = salary; }
        public void setHire_date(HiringDate hire_date) { this.hire_date = hire_date; }
        public void setGender(Gender gender) { this.gender = gender; }

        #endregion

        #region Getter

        public int getID() { return this.ID; }
        public Flag getSecurity_level() { return this.security_level; }
        public int getSalary() { return this.salary; }
        public HiringDate getHire_date() { return this.hire_date; }
        public Gender getGender() { return this.gender; }

        #endregion




        public override string ToString()
        {
            string employeeInfo = $"The Employee ID is {ID}\n" +
                $"The Employee security_level is {security_level}\n" +
                $"The Employee Salary is {salary:c}\n" +
                $"The Employee hire_date is {hire_date.ToString()}\n" +
                $"The Employee gender is {gender}\n";
            return employeeInfo;
        }

        public void readAllData_fromEndUser()
        {
            Console.Write("Please Enter The ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter The security level: ");
            Flag sec;
            Enum.TryParse(Console.ReadLine(), out sec);

            Console.Write("Please Enter The salary: ");
            int sal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter The Gender: ");
            Gender gen;
            Enum.TryParse(Console.ReadLine(), out gen);

            Console.Write("Please Enter The Hire Date: ");
            HiringDate hdate = default; hdate.readDate();

            this.setID(id);
            this.setSecurity_level(sec);
            this.setSalary(sal);
            this.setGender(gen);
            this.setHire_date(hdate);
        }

        class Program
        {

            static void Main(string[] args)
            {
                Employee[] EmpArr = new Employee[3];
                EmpArr[0].setSecurity_level(Flag.DBA);
                EmpArr[1].setSecurity_level(Flag.guest);
                EmpArr[2].setSecurity_level(Flag.full_permissions);


                Console.WriteLine("Emp 1");
                Console.WriteLine(EmpArr[0].ToString());
                Console.WriteLine("Emp 2");
                Console.WriteLine(EmpArr[1].ToString());
                Console.WriteLine("Emp 3");
                Console.WriteLine(EmpArr[2].ToString());


                Console.WriteLine("Please Enter The All Your Info:");
                EmpArr[0].readAllData_fromEndUser();
                Console.WriteLine("");
                Console.WriteLine("Emp 1");
                Console.WriteLine(EmpArr[0].ToString());

            }
        }
    }
}