using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ModelClass
{
    [Table("SGT_GENRE")]
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName{ get; set; }
        public int DisplayOrder{ get; set; }
    }
}
