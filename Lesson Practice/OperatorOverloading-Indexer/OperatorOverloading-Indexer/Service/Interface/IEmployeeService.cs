using OperatorOverloading_Indexer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer.Service.Interface
{
    public interface IEmployeeService
    {

        double GetAllByAverageSalary(Predicate<Employee> predicate);
        
    }
}
