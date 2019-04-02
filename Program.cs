using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book
            {
                Name = "Идиот",
                Cost = 2000,
                Author = "Достоевский",
                Year = 1869
            });
            books.Add(new Book
            {
                Name = "Programming Microsoft ADO.NET ",
                Cost = 20000,
                Author = "David Sceppa",
                Year = 2017
            });

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream writer = new FileStream("books.txt", FileMode.Create))
            {
                binaryFormatter.Serialize(writer, books);
            }

            List<Book> newBooks = new List<Book>();
            using (FileStream reader = new FileStream("books.txt", FileMode.Open))
            {
                newBooks = binaryFormatter.Deserialize(reader) as List<Book>;
            }
            foreach (var book in newBooks)
            {
                Console.WriteLine(book.Name);
            }

            var booksType = typeof(Book);
            var customAattributes = booksType.CustomAttributes;
            foreach (var attribute in customAattributes)
            {
                Console.WriteLine(attribute);
            }
            Console.Read();
        }
    }
}
