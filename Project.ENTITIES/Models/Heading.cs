using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Heading
    {
        public int HeadingID { get; set; }
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }
        public int CategoryID { get; set; }
        public int WriterID { get; set; }


        //Relational Properties
        public virtual Writer Writer { get; set; }
        public virtual Category Category { get; set; }
        public List<Contact> Contacts { get; set; }

    }
}
