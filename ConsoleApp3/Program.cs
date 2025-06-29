using System;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25, 30 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var num in evenNumbers)
                Console.WriteLine(num);


            Console.WriteLine();

            // 2
            var cities = new List<string> { "New York", "London", "Tokyo", "Paris", "Berlin", "Sydney", "Toronto", "Mumbai", "Barcelona" };
            var filteredCities = cities.Where(city => city.StartsWith("L") || city.StartsWith("T"));
            foreach (var city in filteredCities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine();

            //3
            var employees = new List<Employee>
{
            new Employee { Id = 1, Name = "John Smith", Department = "IT", Salary = 75000, Age = 28 },
            new Employee { Id = 2, Name = "Sarah Johnson", Department = "HR", Salary = 65000, Age = 32 },
            new Employee { Id = 3, Name = "Mike Wilson", Department = "IT", Salary = 85000, Age = 35 },
            new Employee { Id = 4, Name = "Emily Davis", Department = "Finance", Salary = 70000, Age = 29 },
            new Employee { Id = 5, Name = "David Brown", Department = "IT", Salary = 95000, Age = 40 },
            new Employee { Id = 6, Name = "Lisa Garcia", Department = "Marketing", Salary = 60000, Age = 26 },
            new Employee { Id = 7, Name = "Robert Taylor", Department = "Finance", Salary = 80000, Age = 38 },
            new Employee { Id = 8, Name = "Jennifer Lee", Department = "HR", Salary = 55000, Age = 24 }
};
            var highEarners = employees.Where(e => e.Salary > 70000);
            foreach (var emp in highEarners)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine();

            //4
            var youngEmployees = employees.Where(e => e.Age < 30);
            foreach (var emp in youngEmployees)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine();

            //5
            var squaredNumbers = numbers.Select(n => n * n);
            foreach (var sq in squaredNumbers)
            {
                Console.WriteLine(sq);
            }

            Console.WriteLine();

            //6
            var cityLengths = cities.Select(city => new { Name = city, Length = city.Length });

            foreach (var item in cityLengths)
            {
                Console.WriteLine($"{item.Name} - {item.Length} xarakter");
            }

            Console.WriteLine();


            //7
            var employeeNme = employees.Select(e => e.Name).ToList();
            foreach (var employee in employeeNme)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine();

            //8
            var averageSalary = employees.Average(e => e.Salary);
            var summaries = employees.Select(e => new
            {
                e.Name,
                e.Department,
                e.Salary,
                AboveAverage = e.Salary > averageSalary
            });

            foreach (var summary in summaries)
            {
                Console.WriteLine($"{summary.Name} - {summary.Department} - {summary.Salary} - {(summary.AboveAverage ? "Ortalama Maasdan Yuxari" : "Ortalama Maasdan Aşağı")}");
            }

            Console.WriteLine();

            //9
            var alphabeticCities = cities.OrderBy(city => city);

            foreach (var city in alphabeticCities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine();


            //10
            var sortedBySalaryDesc = employees.OrderByDescending(e => e.Salary).ToList();
            foreach (var emp in sortedBySalaryDesc)
            {
                Console.WriteLine(emp);

            }

            Console.WriteLine();

            //11
            var employeesSortedByDepartmentAndAge = employees
                .OrderBy(emp => emp.Department)
                .ThenBy(emp => emp.Age)
                .ToList();

            Console.WriteLine("Employees Sorted by Department and Age");
            foreach (var emp in employeesSortedByDepartmentAndAge)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine();

            //12
            var reversed = numbers.OrderDescending();
            foreach (var n in reversed)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();

            // 13
            Console.WriteLine("Order by Department");
            var employeesByDept = employees.GroupBy(e => e.Department);
            foreach (var group in employeesByDept)
                Console.WriteLine($"{group.Key} - {group.Count()} employees");
            Console.WriteLine();


            // 14
            var orders = new List<Order>
{
            new Order { Id = 1, CustomerName = "Alice", Amount = 150.50m, OrderDate = new DateTime(2024, 1, 15) },
            new Order { Id = 2, CustomerName = "Bob", Amount = 89.99m, OrderDate = new DateTime(2024, 2, 10) },
            new Order { Id = 3, CustomerName = "Alice", Amount = 200.00m, OrderDate = new DateTime(2024, 1, 25) },
            new Order { Id = 4, CustomerName = "Charlie", Amount = 75.25m, OrderDate = new DateTime(2024, 3, 5) },
            new Order { Id = 5, CustomerName = "Bob", Amount = 120.75m, OrderDate = new DateTime(2024, 2, 20) },
            new Order { Id = 6, CustomerName = "Diana", Amount = 300.00m, OrderDate = new DateTime(2024, 1, 30) }
};
            var groupedOrders = orders.GroupBy(x => x.CustomerName);
            foreach (var order in groupedOrders)
            {
                Console.WriteLine($"{order.Key}, {order.Sum(x => x.Amount)}");
            }


            Console.WriteLine();

            //15
            var oddevenNumbers = numbers.GroupBy(n => n % 2 == 0 ? "Cut" : "Tek");

            foreach (var num in oddevenNumbers)
            {
                Console.WriteLine(num.Key);

                foreach (var numb in num)
                {
                    Console.WriteLine(numb);
                }
            }

            Console.WriteLine();

            //16
            var averageSalaryEmp = employees.Average(e => e.Salary);
            Console.WriteLine($"Orta emek haqqi: {averageSalaryEmp}");

            Console.WriteLine();

            //17
            var depStats = employees.GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    AverageSalary = g.Average(e => e.Salary),
                    Count = g.Count()
                });
            foreach (var stat in depStats)
            {
                Console.WriteLine($"{stat.Department} - Orta Maas: {stat.AverageSalary}, Emekdas Sayisi: {stat.Count}");
            }

            Console.WriteLine();

            //18
            var totalSum = numbers.Sum();
            var countGreaterThan5 = numbers.Count(n => n > 5);
            Console.WriteLine($"Cem: {totalSum}");
            Console.WriteLine($"5-den boyuk ededlerin sayi: {countGreaterThan5}");

            Console.WriteLine();

            //19
            var oldestEmployee = employees.MaxBy(e => e.Age);
            var youngestEmployee = employees.MinBy(e => e.Age);
            Console.WriteLine($"En yasi: {oldestEmployee}");
            Console.WriteLine($"En genci: {youngestEmployee}");

            Console.WriteLine();

            //20
            var formattedEmployees = employees.OrderByDescending(e => e.Salary).Select(e => $"Ad: {e.Name}, Sobe: {e.Department}, Emek haqqi: {e.Salary} AZN").ToList();

            foreach (var line in formattedEmployees)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();

            //21
            var highSalaryITEmployees = employees.Where(e => e.Department == "IT" && e.Salary > 80000).Select(e => e.Name).ToList();

            foreach (var name in highSalaryITEmployees)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            //22
            var filteredEmployees = employees.Where(e => (e.Name.Contains('a') || e.Name.Contains('e')) &&(e.Department == "IT" || e.Department == "Finance")).ToList();

            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine($"Ad: {emp.Name}, Sobe: {emp.Department}, Emek haqqi: {emp.Salary} AZN");
            }

        }
    }
}

