using OperatorOverloading_Indexer.Models;
using OperatorOverloading_Indexer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer.Service
{
    public class BookService : IBookService
    {
        public int GetCount(Predicate<Book> predicate)
        {
            var books = GetAll();

            return books.FindAll(predicate).Count;

            
        }

        private List<Book> GetAll()
        {
            List<Book> books = new List<Book>();

            Book book1 = new Book()
            {
                Name = "Sefiller",
                Author = "Dostoevsky"

            };

            Book book2 = new Book()
            {
                Name = "1984",
                Author = "George Orwell"

            };
            Book book3 = new Book()
            {
                Name = "Cinayet ve Ceza",
                Author = "Dostoevsky"

            };
            Book book4 = new Book()
            {
                Name = "Sherlock Holmes",
                Author = "Arthur C.D."

            };

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);

            return books;

        }

    }
}
