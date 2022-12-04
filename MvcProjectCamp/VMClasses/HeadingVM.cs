using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProjectCamp.VMClasses
{
    public class HeadingVM
    {
        public Heading Heading  { get; set; }
        public List<Heading> Headings  { get; set; }
    }
}