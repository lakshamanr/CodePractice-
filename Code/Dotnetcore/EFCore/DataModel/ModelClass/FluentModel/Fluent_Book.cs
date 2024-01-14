﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ModelClass
{

    public class Fluent_Book
    { 
        public int BookID{ get; set; }
        public string BookTitle { get; set; }  
        public string ISBN { get; set; }
        public decimal Price { get; set; }  
        public string PriceRange{ get; set; } 
    }
}
