using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDetails
{
    class Employee
    {
        public string company_name = "LTTS";
        string Fname;
        string Lname;
        int psno;


        public Employee(string FirstName,string LastName,int PSNo )
        {
            Fname = FirstName;
            Lname = LastName;
            psno = PSNo;
        }

        string Employee_EmailID()
        {
            return (Fname + Lname + '@' + company_name + ".com");
        }

        int Employee_PSnumber()
        {
            return psno;
        }

        public void GetFullDetailsOfEmployee()
        {
            string FullName = Fname + Lname;
            string EmailID = Employee_EmailID();
            int PsNo = Employee_PSnumber();

            Console.WriteLine("Employee FullName is :- {0}", FullName);
            Console.WriteLine("Employee Email ID is :- {0}", EmailID);
            Console.WriteLine("Employee PSNo is :- {0} ", PsNo);
            Console.WriteLine();


        }

    }

}
