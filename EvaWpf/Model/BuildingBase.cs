using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.Model
{
    abstract class BuildingBase
    {
        public string Name { get; }
        protected BuildingBase(string name) =>
            Name = name;
        public override string ToString() => Name;
    }
}
