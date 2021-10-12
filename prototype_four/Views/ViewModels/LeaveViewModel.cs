using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using prototype_four.Models;

namespace prototype_four.Views.ViewModels
{
    public class LeaveViewModel
    {
        public IEnumerable<LeaveType> LeaveType { get; set; }
        public Leave Leave { get; set; }
    }
}