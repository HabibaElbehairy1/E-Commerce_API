using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.Entities.Products
{
    public class ProductType : BaseEntity
    {
        public string Name { get; private set; } = null!;
        public ICollection<Product> Products { get; private set; } = [];
    }
}
