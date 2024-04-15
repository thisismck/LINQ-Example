using System;
using TCPData;
using TCPExtensions;
using System.Linq;


namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> employeeList = Data.GetEmployees();
            //var filteredEmployees = employeeList.Filter(e => e.AnnualSalary < 50000);
            //foreach (var employee in filteredEmployees)
            //{
            //    Console.WriteLine($"First Name: {employee.FirstName}");
            //    Console.WriteLine($"Last Name: {employee.LastName}");
            //    Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
            //    Console.WriteLine($"Is Manager: {employee.IsManager}");
            //    Console.WriteLine($"Department Id: {employee.DepartmentId}");
            //    Console.WriteLine();
            //}

            //List<Department> departmentList = Data.GetDepartments();
            //var filteredDepartments = departmentList.Where(d => d.Id < 3);
            //foreach (var department in filteredDepartments)
            //{
            //    Console.WriteLine($"Short Name: {department.ShortName}");
            //    Console.WriteLine($"Long Name: {department.LongName}");
            //    Console.WriteLine();
            //}

            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();    

            var resultList = from emp in employeeList
                             join dep in departmentList
                                on emp.DepartmentId equals dep.Id
                                select new
                                {
                                    emp.FirstName,
                                    emp.LastName,
                                    emp.AnnualSalary,
                                    emp.IsManager,
                                    emp.DepartmentId,
                                    dep.ShortName,
                                    dep.LongName
                                };
            Console.WriteLine("Employee Information");
            foreach(var item in resultList)
            {
                Console.WriteLine($"First Name: {item.FirstName}");
                Console.WriteLine($"Last Name: {item.LastName}");
                Console.WriteLine($"Annual Salary: {item.AnnualSalary}");
                Console.WriteLine($"Is Manager: {item.IsManager}");
                Console.WriteLine($"Department Id: {item.DepartmentId}");
                Console.WriteLine($"Short Name: {item.ShortName}");
                Console.WriteLine($"Long Name: {item.LongName}");
                Console.WriteLine();
            }   

            var averageAnnualSalary = employeeList.Average(e => e.AnnualSalary);
            var highestAnnualSalary = employeeList.Max(e => e.AnnualSalary);
            var lowestAnnualSalary = employeeList.Min(e => e.AnnualSalary);

            Console.WriteLine($"Average Annual Salary: {averageAnnualSalary}");
            Console.WriteLine($"Highest Annual Salary: {highestAnnualSalary}");
            Console.WriteLine($"Lowest Annual Salary: {lowestAnnualSalary}");
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}