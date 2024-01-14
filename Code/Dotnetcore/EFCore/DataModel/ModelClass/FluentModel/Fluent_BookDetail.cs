using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.ModelClass
{
    public class Fluent_BookDetail
    { 
        public int BookDetail_ID{ get; set; }

         public string NumberOfChaoer{ get; set; }
        public string NumberOfPager{ get; set; }

        public string Weight{ get; set; }
        public int BookID { get; set; }
        public Fluent_Book FluentBook{ get; set; }
    }
}
