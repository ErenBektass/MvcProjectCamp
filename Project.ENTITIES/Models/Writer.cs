using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Writer
    {
        public int YazarID { get; set; }
        public string WriterName { get; set; }
        public string WriterSurName { get; set; }
        public string WriterImage { get; set; }
        public string WriterEmail { get; set; }
        public string WriterPassword { get; set; }

        //Relational Properties

        public List<Heading> Headings { get; set; }
    }
}
