using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {

            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe", AnnualSalary = 60000.3m, IsManager = true, DepartmentId = 1 },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith", AnnualSalary = 50000, IsManager = false, DepartmentId = 1 },
                new Employee { Id = 3, FirstName = "Tom", LastName = "Jones", AnnualSalary = 45000, IsManager = false, DepartmentId = 2 },
                new Employee { Id = 4, FirstName = "Sally", LastName = "Johnson", AnnualSalary = 55000, IsManager = false, DepartmentId = 2 },
                new Employee { Id = 5, FirstName = "Bob", LastName = "Brown", AnnualSalary = 40000, IsManager = false, DepartmentId = 3 },
                new Employee { Id = 6, FirstName = "Karen", LastName = "Davis", AnnualSalary = 60000, IsManager = true, DepartmentId = 3 },
                new Employee { Id = 7, FirstName = "Mike", LastName = "Miller", AnnualSalary = 50000, IsManager = false, DepartmentId = 3 },
                new Employee { Id = 8, FirstName = "Chris", LastName = "Lee", AnnualSalary = 45000, IsManager = false, DepartmentId = 3 },
                new Employee { Id = 9, FirstName = "Pat", LastName = "Wilson", AnnualSalary = 55000, IsManager = false, DepartmentId = 3 },
                new Employee { Id = 10, FirstName = "Kelly", LastName = "Young", AnnualSalary = 40000, IsManager = false, DepartmentId = 3 }
            };

            return employees;
        }
        public static List<Department> GetDepartments()
        {
            List<Department> employees = new List<Department>();
            employees.Add(new Department { Id = 1, ShortName = "HR", LongName = "Human Resources" });
            employees.Add(new Department { Id = 2, ShortName = "IT", LongName = "Information Technology" });
            employees.Add(new Department { Id = 3, ShortName = "ENG", LongName = "Engineering" });
            return employees;
        }
    }
}
