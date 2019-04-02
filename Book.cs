using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationHomeWork
{
    [CreatedByPerson]
    [Serializable]
    public class Book
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
