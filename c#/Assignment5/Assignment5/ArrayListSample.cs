using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSal { get; set; }
        public string EmpLoc { get; set; }


    }

        internal class ArrayListSample
        {
            static void Main(string[] args)
            {
                //object initilizer or collection initilizer
                //ArrayList e = new ArrayList();//non generic
               
                ArrayList e = new ArrayList()
                   {
new Employee{EmpId=1,EmpName="nick",EmpSal=10000,EmpLoc="Hyd"},
new Employee{EmpId=2,EmpName="john",EmpSal=24000,EmpLoc="Hyd"},
new Employee{EmpId=3,EmpName="faf",EmpSal=21000,EmpLoc="Hyd"},
new Employee{EmpId=3,EmpName="fasil",EmpSal=30000,EmpLoc="Hyd"},
new Employee{ EmpId=4, EmpName="fahadh"},


};
                foreach (Employee i in e)
                {
                    Console.WriteLine(i.EmpId + " " + i.EmpName + " " + i.EmpSal + " " + i.EmpLoc);
                }
                Console.ReadKey();
            }
        }
    }
