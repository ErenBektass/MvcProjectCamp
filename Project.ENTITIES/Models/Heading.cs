using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Heading:BaseEntity
    {
        
        public int HeadingID { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set; }       
        public int CategoryID { get; set; }
        public int WriterID { get; set; }


        //Relational Properties
        public virtual Writer Writer { get; set; }
        public virtual Category Category { get; set; }
        public List<Content> Contents { get; set; }

    }
}   
