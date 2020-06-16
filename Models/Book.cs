using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public float DiscountedPrice { get; set; }

        public virtual Categorybook Categorybook { get; set; }
    }
}
