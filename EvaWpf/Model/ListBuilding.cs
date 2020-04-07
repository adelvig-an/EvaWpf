using System;
using System.Collections.Generic;
using System.Text;

namespace EvaWpf.Model
{
    class ListBuilding
    {
        public List<BuildingBase> categories { get; set; } = new List<BuildingBase>()
        {
            new BuildingBase
            {
                Name = "Жилая недвижимость",
                Items = new List<BuildingBase>(new List<Dwelling>()
                {
                    new Dwelling("Квартира")
                })
            }
        }
    }
}
