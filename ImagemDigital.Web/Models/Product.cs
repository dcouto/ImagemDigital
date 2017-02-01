using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImagemDigital.Web.Models
{
    public class Product : BaseNamedEntity
    {
        public double Cost { get; set; }

        /// <summary>
        /// Examples: "Produtos", "Imã Geladeira", "Convites", "Filmagem"
        /// </summary>
        public virtual ProductCategory Category { get; set; }
    }
}