using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProjectCamp.VMClasses
{
    public class WriteVM
    {
        public Writer Writer  { get; set; }
        public List<Writer> Writers { get; set; }
    }
}