using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTutorials.Data.Entities
{
    public class Mouse
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
        public int Dpi { get; set; }
        public int NumberofButtons { get; set; }

    }
}