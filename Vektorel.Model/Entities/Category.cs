using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Model.Entities
{
    public class Category : IEntity
    {
        public Category()
        {
            //Products = new HashSet<Product>();
            Products = new List<Product>();
        }
        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
