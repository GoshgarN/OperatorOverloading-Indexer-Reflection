using OperatorOverloading_Indexer.Service;
using OperatorOverloading_Indexer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer.Controllers
{
    public class EmployeeController
    {
        public static void GetEmployeeSalaryAverage()
        {
            IEmployeeService employeeService = new EmployeeService();

            Console.WriteLine(employeeService.GetAllByAverageSalary(m=>m.Age > 20 && m.Age <40));
        }



    }
}
