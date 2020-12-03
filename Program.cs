using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Emp
    {
        static void Main(string[] args)
        {
            
            Employee1 e1 = new Employee1("sachin", 8000, 1);
            Console.WriteLine("Empid: " + e1.EMPNO + ", Name: " + e1.NAME + ", Basic salary: " + e1.BASIC + ", Dept No: " + e1.DEPTNO + ", Net salary: " + e1.GetNetSalary());
            Console.ReadLine();
            
            Employee1 e2 = new Employee1("kodag", 20000);
            Console.WriteLine("Empid: " + e2.EMPNO + ", Name: " + e2.NAME + ", Basic salary: " + e2.BASIC + ", Net salary: " + e2.GetNetSalary());
            Console.ReadLine();
            
            Employee1 e3 = new Employee1("sachin");
            Console.WriteLine("Empid: " + e3.EMPNO + ", Name: " + e3.NAME);
            Console.ReadLine();
            
            Employee1 e4 = new Employee1();
            Console.WriteLine("Empid: " + e4.EMPNO + ", Net salary: " + e4.GetNetSalary());
            Console.ReadLine();
        }
    }

    class Employee1
    {
        private string Name;
        private static int EmpNo;
        private decimal Basic;
        private short DeptNo;

        public Employee1()
        {
            EmpNo++;
            this.EMPNO += EmpNo;
        }
        public Employee1(string Name, decimal Basic, short DeptNo)
        {
            EmpNo++;
            this.EMPNO = EmpNo;
            this.NAME = Name;
            this.BASIC = Basic;
            this.DEPTNO = DeptNo;
        }
        public Employee1(string Name, decimal Basic)
        {
            EmpNo++;
            this.EMPNO = EmpNo;
            this.NAME = Name;
            this.BASIC = Basic;
        }
        public Employee1(string Name)
        {
            EmpNo++;
            this.EMPNO = EmpNo;
            this.NAME = Name;
        }
     
        public string NAME
        {
            set
            {
                if (value == "")
                    Console.WriteLine("Name should not be empty");
                else
                    Name = value;

            }
            get { return Name; }
        }

        public int EMPNO
        {
            get;
        }
        public decimal BASIC
        {
            set
            {
                if (value >= 8000 && value <= 100000)
                    Basic = value;
                else
                    Console.WriteLine("Enter valid basic");
            }
            get { return Basic; }
        }

        public short DEPTNO
        {
            set
            {
                if (value >= 0)
                    DeptNo = value;
                else
                    Console.WriteLine("Enter valid Dept no");
            }
            get { return DeptNo; }
        }

        public decimal GetNetSalary()
        {
            if (BASIC >= 8000 && BASIC <= 100000)
            {
                decimal netSal = BASIC + 1000;
                return netSal;
            }
            return BASIC;
        }
    }
}
