using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Writer:BaseEntity
    {
        
        public int WriterID { get; set; }

        [StringLength(50)]
        public string WriterName { get; set; }

        [StringLength(50)]
        public string WriterSurName { get; set; }

        [StringLength(100)]
        public string WriterImage { get; set; }

        [StringLength(50)]
        public string WriterEmail { get; set; }

        [StringLength(20)]
        public string WriterPassword { get; set; }

        //Relational Properties

        public List<Heading> Headings { get; set; }
        
    }
}
