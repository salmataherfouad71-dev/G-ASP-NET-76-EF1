using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._16
{
    public class Book
    {
        public string Title { set; get; }
        public int Id { set; get; }
        public decimal price { set; get; }
        public int pages { set; get; }
        public DateOnly publishedYear { set; get; }
        public bool instock { set; get; }

    }
}
