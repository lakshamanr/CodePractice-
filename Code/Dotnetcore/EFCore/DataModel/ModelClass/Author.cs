using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ModelClass
{
    public class Author
    {
        [Key]
        public int Author_id{ get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName{ get; set; }
        [Required]

        public string LastName { get; set; }
        public string BirthDate{ get; set; }
        public string Location { get; set; }
        [NotMapped]
        public string FullName{ get { return FirstName +string.Empty+ LastName; } }
    }
}
