using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcModalPOC.Models
{
    public class IceCreamVM
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string Brand { get; set; }
        public string Flavor { get; set; }

        public IceCreamVM(string id, string firstName, string brand, string flavor)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.Brand = brand;
            this.Flavor = flavor;
        }
    }
}