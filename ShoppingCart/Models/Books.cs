using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class Books
    {
        [Key]
        public int ID { get; set; }

        [BindProperty]
        [Required]
        public string Name { get; set; }

        [BindProperty]
        [Required]
        public string Author { get; set; }

        [BindProperty]
        public string ISBN { get; set; }
    }

    public class BookList
    {
        public IEnumerable<Books> Books { get; set; }
    }
}