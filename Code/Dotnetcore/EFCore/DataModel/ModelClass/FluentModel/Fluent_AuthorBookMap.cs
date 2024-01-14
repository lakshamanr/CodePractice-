using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ModelClass
{
    public class Fluent_AuthorBookMap
    {
        [ForeignKey("Author")]
        public int Author_id { get; set; }
        [ForeignKey("Book")]
        public int BookID { get; set; }

        public Fluent_Author Author{ get; set; }
        public Fluent_Book Book{ get; set; }
    }
}
