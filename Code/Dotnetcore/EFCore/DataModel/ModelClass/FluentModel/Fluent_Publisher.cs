using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ModelClass
{
    public class Fluent_Publisher
    {
        [Key]
        public int Publisher_ID { get; set; }
        public string Name { get; set; }
        public string Location{ get; set; }

        public List<Fluent_Book> Books{ get; set; }

    }
}
