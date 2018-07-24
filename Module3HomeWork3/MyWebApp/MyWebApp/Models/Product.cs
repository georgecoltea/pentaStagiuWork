using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Details { get; set; }
        public string Price { get; set; }
        public Size Size { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }

    public enum Size
    {
        XS,
        S,
        M,
        L,
        XL,
        XXL
    }
}