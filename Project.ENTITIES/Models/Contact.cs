using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Contact
    {
        
        public int ContactID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserEmail { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }

        [StringLength(1000)]
        public string Message { get; set; }

        //Relational Properties
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

    }
}
