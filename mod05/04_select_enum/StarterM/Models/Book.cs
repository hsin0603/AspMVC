using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Models
{
    public enum BookCategory
    {
        Arts, Cookbooks, Computers, History, Literature
    }

    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public bool InStock { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }

        //public BookCategory? Category { get; set; }
        public IEnumerable<BookCategory> Category { get; set; }

    }
}
