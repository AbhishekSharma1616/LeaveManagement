using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prototype_four.Models
{
    public class Leave
    {
        public int LeaveId { get; set; }
        [Display(Name = "Leave Description")]
        public string LeaveDescription { get; set; }
        public LeaveType LeaveType { get; set; }
        [Display(Name = "Starting and ending date")]
        public string fromTo { get; set; }
        [Display(Name = "Name")]
        public string Useremail { get; set; }
        public int Checked{ get; set; }
        [Display(Name = "Select Type of Leave")]
        public int LeaveTypeId { get; set; }

    }
}