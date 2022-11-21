using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string NameSurname { get; set; }
        public string UserEmail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        //Relational Properties
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

    }
}
