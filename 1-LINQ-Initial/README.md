# LINQ Example Project

This project demonstrates the use of Language Integrated Query (LINQ) in C# to perform various operations on collections of data. It includes examples of filtering, joining, and aggregating data using LINQ queries.

## Getting Started

To get started with this project, clone the repository to your local machine.

### Prerequisites

- .NET Core 3.1 or later
- Basic understanding of C# and LINQ

### Running the Program

Navigate to the project directory and run the program using the .NET CLI:

## Features

This example includes the following LINQ operations:

- **Filtering**: Demonstrates filtering a list of employees to find employees with an annual salary less than a certain threshold.
- **Joining**: Shows how to perform inner joins between two collections (employees and departments) to display detailed employee information.
- **Aggregation**: Calculates and displays the average, highest, and lowest annual salaries from a list of employees.

## Code Explanation

- `Data.GetEmployees()` and `Data.GetDepartments()` methods simulate fetching data from a data source, returning lists of `Employee` and `Department` objects, respectively.
- The main functionality is demonstrated in the `Main` method, where LINQ queries are used to filter, join, and aggregate data.
- First, an inner join is performed between the employee list and the department list to display detailed information about each employee.
- Then, average, highest, and lowest annual salaries are calculated using aggregation functions provided by LINQ.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any improvements or fixes.

## License

This project is not licensed.

## Acknowledgments

- This project uses fictional data for demonstration purposes.
- Thanks to the .NET community for providing extensive documentation and resources on LINQ.
