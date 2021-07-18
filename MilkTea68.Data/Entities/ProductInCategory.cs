using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea68.Data.Entities
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int CategoryIds { get; set; }

        public Category Category { get; set; }
    }
}
