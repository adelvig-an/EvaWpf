using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.Model
{
    class Class1
    {
        public abstract class BuildingBase 
        { 
            public string Name { get; } 
            protected BuildingBase(string name) => 
                Name = name; 
            public override string ToString() => Name; 
        }

        public class Dwelling : BuildingBase 
        { 
            public Dwelling(string name) : base(name) { } 
        }
    }
}
