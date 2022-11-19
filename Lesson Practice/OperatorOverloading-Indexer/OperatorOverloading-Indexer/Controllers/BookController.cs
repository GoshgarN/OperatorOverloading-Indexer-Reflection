using OperatorOverloading_Indexer.Service;
using OperatorOverloading_Indexer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer.Controllers
{
    public class BookController
    {


        public static void GetCount()
        {
            IBookService bookService = new BookService();

            Console.WriteLine(bookService.GetCount(m=>m.Author == "Dostoevsky"));
        }

    }
}
