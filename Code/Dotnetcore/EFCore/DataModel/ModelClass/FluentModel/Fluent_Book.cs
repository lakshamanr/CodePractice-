using System;
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
        [Key] 
        public int BookID{ get; set; }
        public string BookTitle { get; set; }
        [MaxLength(50)]
        [Required]
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        [NotMapped]
        public string PriceRange{ get; set; }

        public Fluent_BookDetail BookDetail{ get; set; }

        [ForeignKey("Publisher")]
        public int Publisher_ID { get; set; }
        public Fluent_Publisher Publisher{ get; set; }

        public List<Fluent_Author> Authors { get; set; }
    }
}
