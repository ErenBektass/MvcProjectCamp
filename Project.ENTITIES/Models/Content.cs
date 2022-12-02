using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Content:BaseEntity
    {
        
        public int ContentID { get; set; }
        public int HeadingID { get; set; }
        

        [StringLength(1000)]
        public string ContentValue { get; set; }


        //Relational Properties        
        public virtual Writer Writer { get; set; }


    }
}
