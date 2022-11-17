using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ__ASSIGN
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }

        public string City { get; set; }
        static void Main(string[] args)
        {
            List<Employee> Emplist = new List<Employee>();
            Employee emp1 = new Employee()
            {
                EmployeeID = 1001,
                FirstName = " Malcolm",
                LastName = "Daruwalla",
                Title = "Manager",
                DOB = Convert.ToDateTime("11/16/1984"),
                DOJ = Convert.ToDateTime("06/08/2011"),
                City = "Mumbai"


            };
            Emplist.Add(emp1);

            Employee emp2 = new Employee()
            {
                EmployeeID = 1002,
                FirstName = " Asdin",
                LastName = "Dhalla",
                Title = "AsstManager",
                DOB = Convert.ToDateTime("08/20/1984"),
                DOJ = Convert.ToDateTime("07/07/2012"),
                City = "Mumbai"


            };
            Emplist.Add(emp2);

            Employee emp3 = new Employee()
            {
                EmployeeID = 1003,
                FirstName = " Madhavi",
                LastName = "Oza",
                Title = "Consultant",
                DOB = Convert.ToDateTime("11/14/1987"),
                DOJ = Convert.ToDateTime("4/12/2015"),
                City = "Pune"


            };
            Emplist.Add(emp3);

            Employee emp4 = new Employee()
            {
                EmployeeID = 1004,
                FirstName = " Saba",
                LastName = "Shaikh",
                Title = "SE",
                DOB = Convert.ToDateTime("6/3/1990"),
                DOJ = Convert.ToDateTime("2/2/2016"),
                City = "Pune"


            };
            Emplist.Add(emp4);

            Employee emp5 = new Employee()
            {
                EmployeeID = 1005,
                FirstName = " Nazia",
                LastName = "Shaikh",
                Title = "SE",
                DOB = Convert.ToDateTime("3/8/1991"),
                DOJ = Convert.ToDateTime("2/2/2016"),
                City = "Mumbai"


            };
            Emplist.Add(emp5);

            Employee emp6 = new Employee()
            {
                EmployeeID = 1006,
                FirstName = " Amit",
                LastName = "Pathak",
                Title = "Consultant",
                DOB = Convert.ToDateTime("11/7/1989"),
                DOJ = Convert.ToDateTime("8/8/2014"),
                City = "Chennai"


            };
            Emplist.Add(emp6);

            Employee emp7 = new Employee()
            {
                EmployeeID = 1007,
                FirstName = " Vijay",
                LastName = "Natrajan",
                Title = "Consultant",
                DOB = Convert.ToDateTime("12/2/1989"),
                DOJ = Convert.ToDateTime("6/1/2015"),
                City = "Mumbai"


            };
            Emplist.Add(emp7);

            Employee emp8 = new Employee()
            {
                EmployeeID = 1008,
                FirstName = " Rahul",
                LastName = "Dubey",
                Title = "Associate",
                DOB = Convert.ToDateTime("11/11/1993"),
                DOJ = Convert.ToDateTime("11/6/2014"),
                City = "Chennai"


            };
            Emplist.Add(emp8);

            Employee emp9 = new Employee()
            {
                EmployeeID = 1009,
                FirstName = " Suresh",
                LastName = "Mistry",
                Title = "Associate",
                DOB = Convert.ToDateTime("8/12/1992"),
                DOJ = Convert.ToDateTime("12/3/2014"),
                City = "Chennai"


            };
            Emplist.Add(emp9);

            Employee emp10 = new Employee()
            {
                EmployeeID = 1010,
                FirstName = " Sumit",
                LastName = "Shah",
                Title = "Manager",
                DOB = Convert.ToDateTime("4/12/1991"),
                DOJ = Convert.ToDateTime("1/2/2016"),
                City = "Pune"


            };
            Emplist.Add(emp10);



            IEnumerable<Employee> Result = from obj in Emplist
                                           select obj;
            Console.WriteLine("DISPLAY DETAILS OF ALL THE EMPLOYEES");
            foreach (Employee emp in Result)
            {
                Console.WriteLine("" + emp.EmployeeID + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Title + "-" + emp.DOB + "-" + emp.DOJ + "-" + emp.City + "");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            IEnumerable<Employee> Result1 = from obj in Emplist
                                            where (obj.City != "Mumbai")
                                            select obj;
            Console.WriteLine("DISPLAY DETAILS OF ALL THE EMPLOYEE WHOSE LOCATION IS NOT MUMBAI");
            foreach (Employee emp in Result1)
            {
                Console.WriteLine("" + emp.EmployeeID + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Title + "-" + emp.DOB + "-" + emp.DOJ + "-" + emp.City + "");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            IEnumerable<Employee> Result2 = from obj in Emplist
                                            where (obj.Title == "AsstManager")
                                            select obj;
            Console.WriteLine("DISPLAY DETAILS OF ALL THE EMPLOYEE WHOSE TITLE IS ASSTMANAGER");
            foreach (Employee emp in Result2)
            {
                Console.WriteLine("" + emp.EmployeeID + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Title + "-" + emp.DOB + "-" + emp.DOJ + "-" + emp.City + "");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            IEnumerable<Employee> Result3 = from obj in Emplist
                                            where (obj.LastName.StartsWith("S"))
                                            select obj;
            Console.WriteLine("DISPLAY DETAILS OF ALL THE EMPLOYEE WHOSE  LASTNAME STSRTS WITH S");
            foreach (Employee emp in Result3)
            {
                Console.WriteLine("" + emp.EmployeeID + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Title + "-" + emp.DOB + "-" + emp.DOJ + "-" + emp.City + "");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            IEnumerable<Employee> Result4 = from obj in Emplist
                                            where (obj.DOJ < Convert.ToDateTime("01/01/2015"))
                                            select obj;
            Console.WriteLine("DISPLAY THE DETAILS OF THE EMPLOYEE WITH DOJ");
            foreach(Employee emp in Result4)
            {
                Console.WriteLine("" + emp.EmployeeID + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Title + "-" + emp.DOB + "-" + emp.DOJ + "-" + emp.City + "");

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            IEnumerable<Employee> Result5 = from obj in Emplist
                                            where (obj.DOB > Convert.ToDateTime("01/01/1990"))
                                            select obj;
            Console.WriteLine("DISPLAY DETAILS OF THE EMPLOYEE WITH DOB");
            foreach(Employee emp in Result5)
            {
                Console.WriteLine("" + emp.EmployeeID + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Title + "-" + emp.DOB + "-" + emp.DOJ + "-" + emp.City + "");

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            IEnumerable < Employee > Result6 = from obj in Emplist
                                               where (obj.Title == "Consultant" || obj.Title == "Associate")
                                               select obj;
            Console.WriteLine("DISPLAY DETAILS OF ALL THE EMPLOYEE WHOSE DESIGNATION IS CONSULTANT AND ASSOCIATE");


            foreach (Employee emp in Result6)
            { 
                Console.WriteLine("" + emp.EmployeeID + "-" + emp.FirstName + "-" + emp.LastName + "-" +  emp.Title + "-" + emp.DOB + "-" + emp.DOJ + "-" + emp.City + "");
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            IEnumerable<Employee> Result7 = from obj in Emplist
                                            select obj;
            Console.WriteLine("DISPLAY TOTAL NUMBER OF EMPLOYEES");
            Console.WriteLine("total no.of employees:{0}", Result7.Count());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(); 
            
            IEnumerable<Employee> Result8 = from obj in Emplist where (obj.City=="Chennai") select obj;

            Console.WriteLine("DISPLAY DETAILS OF THE EMPLOYEE WHO BELONGS TO CHENNAI");
            Console.WriteLine("Total number of employees {0}", Result8.Count());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            var Result9 = Emplist.Select(X => X.EmployeeID);
            Console.WriteLine("DISPLAY HIGHEST EMPLOYEEID");
            Console.WriteLine("Highest EmployeeID is {0}", Result9.Max());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            IEnumerable<Employee> Result10 = from obj in Emplist
                                             where (obj.DOJ>Convert.ToDateTime("1/1/2015"))
                                            select obj;
            Console.WriteLine("DISPLAY TOTAL NUMBER OF EMPLOYEE WHO HAVE JOINED AFTER 1/1/2015");
            Console.WriteLine("Employee with DOJ is {0}", Result10.Count());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            IEnumerable<Employee> Result11 = from obj in Emplist
                                             where (obj.Title != "Associate")
                                             select obj;
            Console.WriteLine("DISPLAY EMPLOYEE WHOSE DESIGNATION IS NOT ASSOCIATE");
                Console.WriteLine("Employee designation is not associate {0}", Result11.Count());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            var Result12 = from obj in Emplist group obj by  obj.City;
            Console.WriteLine("DISPLAY EMPLOYEE DETAILS BASED ON CITY");
            foreach(var  emp in Result12)
            {
                Console.WriteLine("{0}-{1}", emp.Key, emp.Count());
            }
            var Result13 = from obj in Emplist group obj by new { obj.City, obj.Title };
            Console.WriteLine("DISPLAY EMPLOYEE DETAILS BASED ON CITY AND TITLE");
            foreach(var emp in Result13)
            {
                Console.WriteLine("{0} - {1}", emp.Key, emp.Count());
            }
            var Result14 = Emplist.Select(X => X.DOB);
            Console.WriteLine("DISPLAY TOTAL NUMBER OF YOUNGER EMPLOYEES");
            Console.WriteLine("Total number of younger employee {0}", Result14.Min());
            














        }
    }
}