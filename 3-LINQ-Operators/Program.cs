using System;
using System.Collections;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();
            Console.WriteLine("Hello World!");
            AllAnyContains(employees);
            var arrayList = GetHeterogenousDataCollection();
            var stringResults = arrayList.OfType<string>();
            foreach (var item in stringResults)
            {
                Console.WriteLine(item);
            }
            var empResults = from s in arrayList.OfType<Employee>()
                             
                                select s;
            foreach (var item in empResults)
            {
                Console.WriteLine($"{item.LastName} { item.FirstName}");
            }
            ConsoleReadKey();
        }

        public static ArrayList GetHeterogenousDataCollection()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);
            arrayList.Add(new Employee { Id = 1, FirstName = "John", LastName = "Doe", AnnualSalary = 60000, IsManager = false, DepartmentId = 1 });
            arrayList.Add(new Employee { Id = 2, FirstName = "Jane", LastName = "Smith", AnnualSalary = 80000, IsManager = true, DepartmentId = 2 });
            return arrayList;
        }
        static void AllAnyContains(List<Employee> employees)
        {
            var annualSalaryCompare = 20000;

            bool isTrueAll = employees.All(e => e.AnnualSalary > annualSalaryCompare);
            if (isTrueAll)
            {
                Console.WriteLine($"All employees have annual salary greater than {annualSalaryCompare}");
            }
            else
            {
                Console.WriteLine($"Not all employees have annual salary greater than {annualSalaryCompare}");
            }

            bool isTrueAny = employees.Any(e => e.AnnualSalary > annualSalaryCompare);
            if (isTrueAny)
            {
                Console.WriteLine($"At least one employee has annual salary greater than {annualSalaryCompare}");
            }
            else
            {
                Console.WriteLine($"No employee has annual salary greater than {annualSalaryCompare}");
            }

            bool isTrueContains = employees.Contains(employees[1],new EmployeeComparer());
            if (isTrueContains)
            {
                Console.WriteLine($"Employee {employees[1].FirstName} {employees[1].LastName} is in the list");
            }
            else
            {
                Console.WriteLine($"Employee {employees[1].FirstName} {employees[1].LastName} is not in the list");
            }
        }

        public class EmployeeComparer : IEqualityComparer<Employee>
        {
            public bool Equals(Employee x, Employee y)
            {
                if(x.Id == y.Id) return true;
                return false;
            }
            public int GetHashCode(Employee obj)
            {
                if(obj == null) return 0;
                return obj.Id.GetHashCode();
            }
        }
        static void SortOrderBy(List<Employee> employees, List<Department> departments)
        {
            var query = from e in employees
                        join d in departments on e.DepartmentId equals d.Id
                        orderby d.Id
                        select new { e.FirstName, e.LastName, Department = d.LongName, e.AnnualSalary, e.IsManager };

            foreach (var item in query)
            {
                Console.WriteLine($"Name: {item.FirstName,-10} LastName: {item.LastName,-10} \t Department: ({item.Department,-10}) \t {item.AnnualSalary,-10} \t {(item.IsManager ? "Manager" : "Employee")}");
            }
        }
        static void GroupByDepartmentQuerySyntax(List<Employee> employees, List<Department> departments)
        {
            var query = from emp in employees
                        group emp by emp.DepartmentId;
                        
            foreach (var item in query)
            {
                Console.WriteLine($"Department Id: {item.Key,-10}");
                foreach(var inItem in item)
                {
                    Console.WriteLine($"\t{inItem.FirstName} {inItem.LastName} \t {inItem.AnnualSalary} \t {(inItem.IsManager ? "Manager" : "Personel")}");
                }
            }
        }
        static void ToLookupMethod(List<Employee> employees, List<Department> departments)
        {
            var query = employees.OrderBy(o => o.AnnualSalary).ToLookup(e => e.DepartmentId);

            foreach (var item in query)
            {
                Console.WriteLine($"Department Id: {item.Key,-10}");
                foreach (var inItem in item)
                {
                    Console.WriteLine($"\t{inItem.FirstName} {inItem.LastName} \t {inItem.AnnualSalary} \t {(inItem.IsManager ? "Manager" : "Personel")}");
                }
            }
        }
        static void SortOrderByDepartmentIdQuerySyntax(List<Employee> employees, List<Department> departments)
        {
            var query = from emp in employees
                        join dept in departments
                        on emp.DepartmentId equals dept.Id
                        orderby dept.Id, emp.AnnualSalary descending
                        select new { emp.FirstName, emp.LastName, Department = dept.LongName, emp.AnnualSalary, emp.IsManager };
            foreach (var item in query)
            {
                Console.WriteLine($"Name: {item.FirstName,-10} LastName: {item.LastName,-10} \t Department: ({item.Department,-20}) \t {item.AnnualSalary,-10} \t {(item.IsManager ? "Manager" : "Employee")}");
            }
        }
        static void SortOrderByDepartmentIdMethodSyntax(List<Employee> employees, List<Department> departments)
        {
            var query = employees.Join(departments, e => e.DepartmentId, d => d.Id,
                        (e, d) => new { e.FirstName, e.LastName, Department = d.LongName, e.AnnualSalary, e.IsManager }).OrderBy(x => x.Department).ThenBy(o=>o.AnnualSalary);
            foreach (var item in query)
            {
                Console.WriteLine($"Name: {item.FirstName,-10} LastName: {item.LastName,-10} \t Department: ({item.Department,-20}) \t {item.AnnualSalary,-10} \t {(item.IsManager ? "Manager" : "Employee")}");
            }
        }

        static void ConsoleReadKey()
        {
            Console.ReadKey();
        }

    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool IsManager { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
    }
    public static class Data
    {
        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>()
            {
                new Department { Id = 1, ShortName = "HR", LongName = "Human Resources" },
                new Department { Id = 2, ShortName = "IT", LongName = "Information Technology" },
                new Department { Id = 3, ShortName = "FN", LongName = "Finance" },
            };
            return departments;
        }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe", AnnualSalary = 60000, IsManager = true, DepartmentId = 1 },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith", AnnualSalary = 80000, IsManager = true, DepartmentId = 2 },
                new Employee { Id = 3, FirstName = "Tom", LastName = "Jones", AnnualSalary = 50000, IsManager = false, DepartmentId = 1 },
                new Employee { Id = 4, FirstName = "Sue", LastName = "Johnson", AnnualSalary = 90000, IsManager = true, DepartmentId = 3 },
                new Employee { Id = 5, FirstName = "Bob", LastName = "Brown", AnnualSalary = 40000, IsManager = false, DepartmentId = 2 },
                new Employee { Id = 6, FirstName = "Alice", LastName = "White", AnnualSalary = 70000, IsManager = false, DepartmentId = 1 },
                new Employee { Id = 7, FirstName = "Eve", LastName = "Black", AnnualSalary = 30000, IsManager = false, DepartmentId = 3 },
                new Employee { Id = 8, FirstName = "Sam", LastName = "Green", AnnualSalary = 100000, IsManager = true, DepartmentId = 2 },
            };
            return employees;
        }

    }

}
