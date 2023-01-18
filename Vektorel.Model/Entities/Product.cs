using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Model.Entities
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }

        public int? CategoryId { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }

        public virtual Category Category { get; set; }
        // Eager loading - Lazy loading

    }
}
