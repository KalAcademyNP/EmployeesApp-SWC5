using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp
{
    class Employee
    {
        private const string TEXT_FILE_NAME = "Employee.txt";
        public string Name { get; set; }
        public string Title { get; set; }

        public static void WriteEmployee(Employee employee)
        {
            var employeeData = $"{employee.Name}, {employee.Title}";
            FileHelper.WriteTextFile(TEXT_FILE_NAME, employeeData);
        }
    }
}
