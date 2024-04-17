using System;

namespace LINQExamples_1
{
    public static class EnumerableCollectionExtensionMethods
    {
        public static IEnumerable<Employee> GetHighSalariedEmployees(this IEnumerable<Employee> employees)
        {
            return employees.Where(employee => employee.AnnualSalary > 50000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = Data.GetEmployees();
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();
            List<Department> departmentList = Data.GetDepartments();

            //var results = employees.Select(e => new
            //{
            //    FullName = e.FirstName + " " + e.LastName,
            //    AnnualSalary = e.AnnualSalary,
            //    Department = departments.Where(d => d.Id == e.DepartmentId).FirstOrDefault().LongName
            //});

            //foreach (var result in results)
            //{
            //    Console.WriteLine($"{result.FullName} \t {result.AnnualSalary}\t {result.Department}");
            //}


            //var results = employees.Select(e => new
            //{
            //    FullName = e.FirstName + " " + e.LastName,
            //    AnnualSalary = e.AnnualSalary,
            //    Department = departments.Where(d => d.Id == e.DepartmentId).FirstOrDefault().LongName
            //}).Where(e => e.AnnualSalary > 80000);

            //foreach (var result in results)
            //{
            //    Console.WriteLine($"{result.FullName} \t {result.AnnualSalary}\t {result.Department}");
            //}

            //var results = from emp in employees
            //              where emp.AnnualSalary > 50000
            //              select new
            //              {
            //                  FullName = emp.FirstName + " " + emp.LastName,
            //                  AnnualSalary = emp.AnnualSalary
            //              };

            //// results are executed when we iterate over them
            //foreach (var result in results)
            //{
            //    Console.WriteLine($"{result.FullName} \t {result.AnnualSalary}");
            //}

            //var results = from emp in employees.GetHighSalariedEmployees()
            //              select new
            //              {
            //                  FullName = emp.FirstName + " " + emp.LastName,
            //                  AnnualSalary = emp.AnnualSalary
            //              };
            //foreach (var result in results)
            //{
            //    Console.WriteLine($"{result.FullName} \t {result.AnnualSalary}");
            //}
            //employees.Add(new Employee { Id = 9, FirstName = "New", LastName = "Employee", AnnualSalary = 100000, IsManager = true, DepartmentId = 2 });

            ////Join Operation Example - Method Syntax
            //var results = departmentList.Join(employeeList,
            //    department => department.Id,
            //    employee => employee.DepartmentId,
            //    (department, employee) => new
            //    {
            //        FullName = employee.FirstName + " " + employee.LastName,
            //        AnnualSalary = employee.AnnualSalary,
            //        Department = department.LongName
            //    });

            //foreach (var result in results)
            //{
            //    Console.WriteLine($"{result.FullName} \t {result.AnnualSalary}\t {result.Department}");
            //}


            //// Join Operation Example - Query Syntax
            //var results = from dept in departmentList
            //              join emp in employeeList
            //              on dept.Id equals emp.DepartmentId
            //              select new
            //              {
            //                  FullName = emp.FirstName + " " + emp.LastName,
            //                  AnnualSalary = emp.AnnualSalary,
            //                  Department = dept.LongName
            //              };
            //foreach (var result in results)
            //{
            //    Console.WriteLine($"{result.FullName} \t {result.AnnualSalary}\t {result.Department}");
            //}

            //// GroupJoin Operation Example - Method Syntax
            //var results = departmentList.GroupJoin(employeeList,
            //    dept => dept.Id,
            //    emp => emp.DepartmentId,
            //    (dept, empGroup) => new
            //    {
            //        Department = dept.LongName,
            //        Employees = empGroup
            //    });

            //foreach (var result in results)
            //{
            //    Console.WriteLine($"Department: {result.Department}");
            //    foreach (var emp in result.Employees)
            //    {
            //        Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
            //    }
            //}

            var results = from dept in departmentList
                          join emp in employeeList
                          on dept.Id equals emp.DepartmentId
                          into employeeGroup
                          select new
                          {
                              Employees = employeeGroup,
                              Department = dept.LongName
                          };
            foreach (var result in results)
            {
                Console.WriteLine($"Department: {result.Department}");
                foreach (var emp in result.Employees)
                {
                    Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
                }
            }



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