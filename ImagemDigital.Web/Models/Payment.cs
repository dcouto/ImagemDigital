using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImagemDigital.Web.Models
{
    public class Payment : BaseEntity
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public virtual Event Event { get; set; }
    }
}