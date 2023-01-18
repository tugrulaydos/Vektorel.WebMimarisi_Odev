using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Model.Entities
{
    public class Supplier:IEntity
    {
        public int SupplierID { get; set; }

        public string CompanyName { get; set; }

        public string? ContactName { get; set; }

        public string? Country { get; set; }

        public string? Region { get; set; }   
        
        public List<Product> products { get; set; }


    }
}
