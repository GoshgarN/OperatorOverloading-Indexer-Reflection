using OperatorOverloading_Indexer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer.Service.Interface
{
    public interface IPersonService
    {
        List<string> GetFullData(Predicate<Person> predicate);

        int GetFilteredDataCount(Predicate<Person> predicate);
    }
}
