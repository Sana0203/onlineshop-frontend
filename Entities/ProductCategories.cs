using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopBackend.Entities
{
    public class ProductCategories : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}