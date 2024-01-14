using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ModelClass
{
    public class Fluent_Author
    {
        
        public int Author_id{ get; set; }

         
        public string FirstName{ get; set; } 

        public string LastName { get; set; }
        public string BirthDate{ get; set; }
        public string Location { get; set; }
        
        public string FullName{ get { return FirstName +string.Empty+ LastName; } }

        
        public ICollection<Fluent_AuthorBookMap> BookAuthorMap { get; set; }

    }
}
