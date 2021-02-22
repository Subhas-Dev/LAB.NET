using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lab
{
    //The following topics are covered : 
    // Using Unanonymous function C# 2
    // Using Lamba Expression C# 3
    // Using Delegates.
    // 

    class Program
    { 
        // A delegegate is a type safe function pointer.
        public delegate void GreetDelegate(string msg);

        static void Main(string[] args)
        {
            List<Employee> lstEmployees = new List<Employee>()
            {
                new Employee { EmpId = 102, EmpName = "Sue",Salary=5000,Experience=5 },
                new Employee {EmpId = 202, EmpName = "John",Salary=600,Experience=4},
                new Employee {EmpId=302, EmpName="Jack",Salary=3000,Experience=3},
                new Employee {EmpId=402, EmpName="Peter",Salary=700,Experience=6}
            };

            IsPromotable isPromotable = new IsPromotable(IsEligibleForPromotion);
            Employee.PromoteEmployee(lstEmployees, isPromotable);

            Console.WriteLine("Promotion using lambda expression");
            Employee.PromoteEmployee(lstEmployees, emp=> emp.Experience>=5);

            //Console.WriteLine("FindMethod1 result:" + FindMethod1(lstEmployees));
            FindMethod1(lstEmployees);
            FindMethod2(lstEmployees);
            FindMethod3(lstEmployees);

            Greet("Subhas");

            GreetDelegate greetdel = new GreetDelegate(Greet);
            greetdel("Spider Man");


            Console.ReadLine();
        }

        static bool IsEligibleForPromotion(Employee emp) 
        {
            if (emp.Experience >= 5) { return true; } else return false;
         
        }
        static bool FindMethod1(List<Employee> emplist) 
        {
            //Search for employee 102;
            bool found = false;
            foreach (Employee emp in emplist)
            {
                if (emp.EmpId == 102) 
                    found =true;
                    Console.WriteLine(" FindMethod1 result : Id = {0}, Name = {1}", emp.EmpId, emp.EmpName);

                break;
            }
            return found;
        }


        // Step 1
        public static bool FindEmployee(Employee Emp)
        {
            return Emp.EmpId == 102;
        }

        static void FindMethod2(List<Employee> emplist) 
        {
            //using lambda expression
            //Step 2
            Predicate<Employee> empPredicate = new Predicate<Employee>(FindEmployee);

            //Step 3
            // emp => FindEmployee(emp) : emp goes to, pass employee object to this method
            Employee employee = emplist.Find(emp => FindEmployee(emp));
            Console.WriteLine(" FindMethod2 Id = {0}, Name = {1}", employee.EmpId, employee.EmpName);

        }

        public static void FindMethod3(List<Employee> emplist) 
        {
            //using anonymous function
            Employee employee = emplist.Find(delegate (Employee emp) { return emp.EmpId == 102; });
            Console.WriteLine(" FindMethod3 Id = {0}, Name = {1}", employee.EmpId, employee.EmpName);

        }

        private static void Greet(string msg) 
        {
            Console.WriteLine("Hello {0}", msg);
        }
    }

    // https://www.youtube.com/watch?v=s0tkKZoMN1Y
    public delegate bool IsPromotable(Employee emp);
    public class Employee 
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee0(List<Employee> employees) 
        {
            foreach (Employee emp in employees)
            {
                if (emp.Experience >= 5)
                {
                    Console.WriteLine(emp.EmpName + "promoted");
                }

            }
        }

        public static void PromoteEmployee(List<Employee> employees,IsPromotable isEligibleToPromote)
        {
            foreach (Employee emp in employees)
            {
                if (isEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.EmpName + " promoted");
                }

            }
        }

        public static void PreviewEmployee(List<Employee> employees, IsPromotable isEligibleToPromote)
        {
            foreach (Employee emp in employees)
            {
                if (!isEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.EmpName + " under review");
                }

            }
        }

        public static void PreviewDriver(List<Employee> employees, IsPromotable isEligibleToPromote)
        {
            foreach (Employee emp in employees)
            {
                if (!isEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.EmpName + " under review");
                }

            }
        }
    }
}
