using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProjectCamp.VMClasses
{
    public class ContentVM
    {
        public Contact Contact { get; set; }
        public List<Contact> Contacts  { get; set; }
}
}