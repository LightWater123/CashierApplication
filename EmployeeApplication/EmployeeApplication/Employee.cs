using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    internal class Employee
    {
        // encapsulation

        private string empID;
        private string fName;
        private string lName;
        private string position;


        public string EmpID
        {
            get { return empID; }
            set { empID = value; }
        }
        public string FName
        {
            get { return fName; }
            set { fName = value; }

        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        // overloaded constructors
        public Employee(string empID, string fName, string lName, string position)
        {
            this.empID = empID;
            this.fName = fName;
            this.lName = lName;
            this.position = position;
        }
        public Employee(string empID)
        {
            this.empID = empID;
        }
    }
}
