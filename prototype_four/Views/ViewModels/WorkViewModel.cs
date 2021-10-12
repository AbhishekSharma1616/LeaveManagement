using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using prototype_four.Models;

namespace prototype_four.ViewModels
{
    public class WorkViewModel
    {
        public IEnumerable<Team> Team { get; set; }
        public Work Work { get; set; }
    }
}