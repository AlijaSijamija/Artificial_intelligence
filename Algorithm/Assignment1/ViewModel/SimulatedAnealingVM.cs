using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.ViewModel
{
    public class SimulatedAnealingVM
    {
        public int dimension { get; set; }
        public int[] array { get; set; }
        public int heuristic { get; set; }
        public int counter { get; set; }
        public int T0 { get; set; }
        public int coolingFactor { get; set; }

        public List<SelectListItem> dimensions { get; set; }
    }
}
