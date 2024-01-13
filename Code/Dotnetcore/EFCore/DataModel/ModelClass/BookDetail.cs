using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ModelClass
{
    public class BookDetail
    {
        [Key]
        public int BookDetail_ID{ get; set; }

         public string NumberOfChaoer{ get; set; }
        public string NumberOfPager{ get; set; }

        public string Weight{ get; set; }
    }
}
