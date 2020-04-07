using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.Model
{
    class LandPlot
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
