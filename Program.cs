using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            CEO c = new CEO("Sachin", 1, 70000);
            Manager m = new Manager("kodag", 2, 50000, "IT");
            GeneralManager gm = new GeneralManager("Ashish", 3, 60000, "Sales", "promotion");
            Console.WriteLine(c.EMPNO + " " + c.NAME + " " + c.DEPTNO + " " + c.BASIC + " " + c.CalcNetSalary());
            Console.WriteLine(m.EMPNO + " " + m.NAME + " " + m.DEPTNO + " " + m.BASIC + " " + m.DESGN + " " + m.CalcNetSalary());
            Console.WriteLine(gm.EMPNO + " " + gm.NAME + " " + gm.DEPTNO + " " + gm.BASIC + " " + gm.DESGN + " " + gm.PERKS + " " + gm.CalcNetSalary());
            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        private string Name;
        public string NAME
        {
            set
            {
                if (value != "")
                    Name = value;
                else
                    Console.WriteLine("Please enter Name");
            }
            get
            {
                return Name;
            }

        }

        private static int count = 0;
        private int EmpNo; 
        public int EMPNO
        {
            get
            {
                return EmpNo;
            }
        }

        private short DeptNo;
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    DeptNo = value;
                else
                    Console.WriteLine("PLease enter valid dept. Number");
            }
            get
            {
                return DeptNo;
            }
        }

        protected decimal Basic;
        public abstract decimal BASIC
        {
            set;
            get;
        }
        public abstract decimal CalcNetSalary();

        public Employee(short DEPTNO = 10, string NAME = "NoName")
        {
            count++;
            EmpNo = count;
            this.DEPTNO = DEPTNO;
            this.NAME = NAME;
        }
    }

    class Manager : Employee
    {
        private string Designation;
        public string DESGN
        {
            set
            {
                if (value != "")
                    Designation = value;
                else
                    Console.WriteLine("Please Enter Designation");
            }
            get
            {
                return Designation;
            }

        }

        public override decimal BASIC
        {
            set
            {
                if (value >= 20000 && value <= 100000)
                    Basic = value;
                else
                    Console.WriteLine("Salary must be between 20K to 100K");
            }

            get
            {
                return Basic;
            }
        }

        public Manager(string NAME, short DEPTNO, decimal BASIC, string DESGN = "NoDesignation") : base(DEPTNO, NAME)
        {
            this.DESGN = DESGN;
            this.BASIC = BASIC;
        }

        public override decimal CalcNetSalary()
        {
            return BASIC + 500;
        }
    }


    class GeneralManager : Manager
    {
        private string Perks;
        public string PERKS
        {
            set
            {
                Perks = value;
            }
            get
            {
                return Perks;
            }
        }

        public new decimal BASIC
        {
            set
            {
                if (value >= 50000 && value <= 1500000)
                    Basic = value;
                else
                    Console.WriteLine("Salary must be 50K to 150K");
            }

            get
            {
                return Basic;
            }
        }
        public GeneralManager(string NAME, short DEPTNO, decimal BASIC, string DESGN, string PERKS = "NoPerks") : base(NAME, DEPTNO, DESGN)
        {
            this.PERKS = PERKS;
            this.BASIC = BASIC;
        }

        public override decimal CalcNetSalary()
        {
            return BASIC + 500;
        }
    }

    class CEO : Employee
    {

        public override decimal BASIC
        {
            set
            {
                if (value >= 70000 && value <= 2000000)
                    Basic = value;
                else
                    Console.WriteLine("Salary must be 70K to 200K");
            }

            get
            {
                return Basic;
            }
        }

        public CEO(string NAME, short DEPTNO, decimal BASIC) : base(DEPTNO, NAME)
        {
            this.BASIC = BASIC;
        }

        public sealed override decimal CalcNetSalary()
        {
            return BASIC + 500;
        }
    }

}











