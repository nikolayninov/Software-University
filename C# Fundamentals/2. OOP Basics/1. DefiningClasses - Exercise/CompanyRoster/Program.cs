using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster {
    public class Program {
        static void Main (string[] args) {
            int n = Int32.Parse (Console.ReadLine ());
            var departments = new Dictionary<string, List<decimal>> ();
            var employees = new List<Employee> ();
            for (int i = 0; i < n; i++) {
                var line = Console.ReadLine ().Split (' ').ToArray ();

                string name = line[0];
                decimal salary = Decimal.Parse (line[1]);
                string position = line[2];
                string department = line[3];

                if (!departments.ContainsKey (department)) {
                    departments.Add (department, new List<decimal> ());
                }
                departments[department].Add (salary);

                var employee = new Employee (name, salary, position, department);

                if (line.Length > 4) {
                    int age;
                    if (Int32.TryParse (line[4], out age)) {
                        employee.Age = age;
                        if (line.Length > 5) {
                            employee.Email = line[5];
                        }
                    } else {
                        employee.Email = line[4];
                        if (line.Length > 5) {
                            employee.Age = Int32.Parse (line[5]);
                        }
                    }
                }

                employees.Add (employee);
            }
            Dictionary<string, decimal> salaries = departments.OrderByDescending (x => x.Value.Average ()).ToDictionary (x => x.Key, x => x.Value.Average ());

            var bestDepartment = "";
            foreach (var sal in salaries) {
                bestDepartment = sal.Key;
                break;
            }
            employees = employees.FindAll (x => x.Department == bestDepartment).OrderByDescending (x => x.Salary).ToList ();
            System.Console.WriteLine ($"Highest Average Salary: {bestDepartment}");
            foreach (var emp in employees) {
                System.Console.WriteLine ($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
            }
        }
    }
}