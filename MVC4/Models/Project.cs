using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Stage { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public int ProjectManager { get; set; }
        public DateTime TargetOnboardingDate { get; set; }
        public int Description { get; set; }
    }
}