using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProjectCamp.VMClasses
{
    public class AboutVM
    {
        public About  About { get; set; }
        public List<About> Abouts { get; set; }
    }
}