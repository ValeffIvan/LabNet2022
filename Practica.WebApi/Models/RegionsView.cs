using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.WebApi.Models
{
    public class RegionsView
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }

        public RegionsView() { }
    }
}