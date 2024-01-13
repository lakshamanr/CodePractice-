using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.ModelClass
{
    public class BookDetail
    {
        [Key]
        public int BookDetail_ID{ get; set; }

         public string NumberOfChaoer{ get; set; }
        public string NumberOfPager{ get; set; }

        public string Weight{ get; set; }

        [ForeignKey("Book")]
        public int BookID { get; set; }
        public Book Book { get; set; } 
    }
}
