using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImagemDigital.Web.Models
{
    public class Event : BaseEntity
    {
        public DateTime Date { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Package> Packages { get; set; }
    }
}