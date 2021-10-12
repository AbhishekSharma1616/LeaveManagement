using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prototype_four.Models
{
    public class Work
    {
        [Key]
        public int WorkId { get; set; }
        [Display(Name = "Task Name")]
        public string WorkName { get; set; }
        public string Description { get; set; }
        public Team TaskTeam { get; set; }
        //public int MyProperty { get; set; }
        [Display(Name = "Select Team")]
        public int TeamId { get; set; }
    }
}