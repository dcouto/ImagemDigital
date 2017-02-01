using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImagemDigital.Web.Models
{
    public class Package : BaseNamedEntity
    {
        public double PhotographyCost { get; set; }
        public double CinematographyCost { get; set; }
        
        /// <summary>
        /// Examples: "Infantil (Kids)", "Casamento e 15 Anos"
        /// </summary>
        public virtual PackageCategory Category { get; set; }

        /// <summary>
        /// Examples: "Basic", "Master", "TOP", "Premium", "Gold"
        /// </summary>
        public virtual PackageLevel Level { get; set; }
    }
}