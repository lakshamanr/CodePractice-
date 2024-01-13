using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ModelClass
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryI_D { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
