using System;
using System.Diagnostics.CodeAnalysis;

namespace LINQMore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();

            //// Equality Operator
            //// SequenceEqual
            ///
            //var integerList1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            //var integerList2 = new List<int> { 1, 2, 3, 4, 5, 6 };

            //var boolResult = integerList1.SequenceEqual(integerList2);

            //Console.WriteLine(boolResult);

            //var employeeListForCompare = Data.GetEmployees();

            //var boolResult = employeeList.SequenceEqual(employeeListForCompare, new EmployeeComparer());

            //Console.WriteLine(boolResult);

            //// Concatenation Operator

            //var integerList1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            //var integerList2 = new List<int> { 7, 8, 9, 10 };

            //IEnumerable<int> integerList3 = integerList1.Concat(integerList2);

            //foreach (var item in integerList3)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Employee> employeeListForConcat = new List<Employee> { new Employee { Id=9, FirstName = "Mert Can", LastName = "Kasapoğlu", AnnualSalary = 100000, DepartmentId = 2, IsManager =true } };

            //var employeeListConcat = employeeList.Concat(employeeListForConcat);

            //foreach (var item in employeeListConcat)
            //{
            //    Console.WriteLine(item.FirstName);
            //}

            //// Aggregate Operator

            //decimal annualSalary = employeeList.Sum(e => e.AnnualSalary);
            //Console.WriteLine(annualSalary);
            //decimal totalAnnualSalary = employeeList.Aggregate<Employee, decimal>(0,(totalAnnualSalary, e)=>
            //{   
            //    var bonus = (e.IsManager) ? 0.04m : 0.02m;
            //    totalAnnualSalary = (e.AnnualSalary + (e.AnnualSalary * bonus)) + totalAnnualSalary;
            //    return totalAnnualSalary;
            //});
            //Console.WriteLine(totalAnnualSalary);

            //string data = employeeList.Aggregate<Employee, string>("Employees Annual Salaries (including bonus): ", (result, e) =>
            //{
            //    var bonus = (e.IsManager) ? 0.04m : 0.02m;
            //    result += $"\n{e.FirstName} {e.LastName} : {e.AnnualSalary + (e.AnnualSalary * bonus)}";
            //    return result;

            //});
            //Console.WriteLine(data);

            //////Average Operator

            //decimal averageSalary = employeeList.Average(e => e.AnnualSalary);
            //Console.WriteLine($"Average Salary is: {averageSalary}");

            ////// Count Operator

            //int count = employeeList.Count(e => e.DepartmentId == 2);
            //Console.WriteLine($"Department 2 employee count: {count}");

            //// Sum Operator

            //decimal sum = employeeList.Sum(e => e.AnnualSalary);
            //Console.WriteLine($"Total Annual Salary: {sum}");

            //// Max Operator

            //decimal max = employeeList.Max(e => e.AnnualSalary);
            //Console.WriteLine($"Max Annual Salary: {max}");

            //// Min Operator

            //decimal min = employeeList.Min(e => e.AnnualSalary);
            //Console.WriteLine($"Min Annual Salary: {min}");

            //// Genertion Operators - Range, Repeat, Empty, DefaultIfEmpty

            //var range = Enumerable.Range(1, 10);
            //foreach (var item in range)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //var repeat = Enumerable.Repeat("Hello", 5);
            //foreach (var item in repeat)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //var empty = Enumerable.Empty<string>();
            //Console.WriteLine(empty.Count());
            //Console.WriteLine();

            //var defaultIfEmpty = employeeList.Where(e => e.DepartmentId == 4).DefaultIfEmpty(new Employee { Id = 0, FirstName = "No Employee", LastName = "No Employee", AnnualSalary = 0, DepartmentId = 4, IsManager = false });
            //foreach (var item in defaultIfEmpty)
            //{
            //    Console.WriteLine(item.FirstName);
            //}

            //// Set Operators - Distinct, Except, Intersect, Union

            //IEnumerable<int> distinct = employeeList.Select(e => e.DepartmentId).Distinct();
            //foreach (var item in distinct)
            //{
            //    Console.WriteLine(item);
            //}

            //IEnumerable<int> departmentIds = new List<int> { 1, 2, 3 };
            //IEnumerable<int> departmentIds2 = new List<int> { 2, 3, 4 };

            //var except = departmentIds.Except(departmentIds2);
            //foreach (var item in except)
            //{
            //    Console.WriteLine(item);
            //}

            //var intersect = departmentIds.Intersect(departmentIds2);
            //foreach (var item in intersect)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //var union = departmentIds.Union(departmentIds2);
            //foreach (var item in union)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = employeeList.Except(new List<Employee> { new Employee { Id = 1, FirstName = "John", LastName = "Doe", AnnualSalary = 60000, DepartmentId = 1, IsManager = true } }, new EmployeeComparer());
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
            //}
            //Console.WriteLine();
            //var result2 = employeeList.Intersect(new List<Employee> { new Employee { Id = 1, FirstName = "John", LastName = "Doe", AnnualSalary = 60000, DepartmentId = 1, IsManager = true } }, new EmployeeComparer());
            //foreach (var item in result2)
            //{
            //    Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
            //}

            //// Partioning Operators - Skip, SkipWhile, Take, TakeWhile

            //var skip = employeeList.Skip(3);
            //foreach (var item in skip)
            //{
            //    Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
            //}

            //Console.WriteLine();

            //var skipWhile = employeeList.SkipWhile(e => e.AnnualSalary < 80000);
            //foreach (var item in skipWhile)
            //{
            //    Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
            //}

            //Console.WriteLine();

            //var take = employeeList.Take(3);
            //foreach (var item in take)
            //{
            //    Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
            //}

            //Console.WriteLine();

            //var takeWhile = employeeList.TakeWhile(e => e.AnnualSalary < 80000);

            //foreach (var item in takeWhile)
            //{
            //    Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
            //}

            //// Conversion Operators - ToArray, ToList, ToDictionary, ToLookup

            //List<Employee> results = (from emp in employeeList
            //                         where emp.AnnualSalary > 60000
            //                         select emp).ToList();
            //foreach(var item in results)
            //{
            //    Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
            //}

            //Console.WriteLine();

            //Employee[] resultsArray = (from emp in employeeList
            //                           where emp.AnnualSalary > 60000
            //                           select emp).ToArray();
            //foreach (var item in resultsArray)
            //{
            //    Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
            //}

            //Console.WriteLine();

            //Dictionary<int, Employee> resultsDictionary =   (from emp in employeeList
            //                                                where emp.AnnualSalary > 60000
            //                                                select emp).ToDictionary(e => e.Id);
            //foreach (var item in resultsDictionary)
            //{
            //    Console.WriteLine($"{item.Key} {item.Value.FirstName} {item.Value.LastName}");
            //}

            //Console.WriteLine();

            //ILookup<int, Employee> resultsLookup = (from emp in employeeList
            //                                        where emp.AnnualSalary > 60000
            //                                        select emp).ToLookup(e => e.DepartmentId);
            //foreach (var item in resultsLookup)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var emp in item)
            //    {
            //        Console.WriteLine($"{emp.Id} {emp.FirstName} {emp.LastName}");
            //    }
            //}

            //// Let clause and into clause

            var results = from emp in employeeList
                          let annualSalary = emp.AnnualSalary + (emp.AnnualSalary * ((emp.IsManager) ? 0.04m : 0.02m))
                            where annualSalary > 80000
                            select new { emp.FirstName, emp.LastName, AnnualSalary = annualSalary };
            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.AnnualSalary}");
            }

            results.ToList().ForEach(e => Console.WriteLine($"{e.FirstName} {e.LastName} {e.AnnualSalary}"));


            Console.ReadKey();
        }
    }

    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals([AllowNull] Employee x, [AllowNull] Employee y)
        {
            if(x.Id == y.Id && x.FirstName == y.FirstName && x.LastName == y.LastName)
            {
                return true;
            }
            return false;
        }
        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id.GetHashCode();
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