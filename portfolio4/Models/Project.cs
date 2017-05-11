using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace portfolio4.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string gitUrl { get; set; }
        public string liveUrl { get; set; }
        public string projectImage { get; set; }
    }
}