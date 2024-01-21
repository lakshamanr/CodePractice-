using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ModelClass
{
    public class BookView
    { 
        public int BookID { get; set; }
        public string BookTitle { get; set; } 
        public string ISBN { get; set; }
        public int Publisher_ID { get; set; }
    }
     
}
