using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagementDemo
{
    public class Rice
    {
        public List<TypesOfRice> typesOfRice;
        public List<TypesOfRice> typesOfGrains;
        public List<TypesOfRice> typesOfwheats;

    }
    public class TypesOfRice
    {
        public int Name { get; set; }
        public int weight { get; set; }
        public int Price { get; set; }

    }
    public class TypesOfGrains
    {
        public int Name { get; set; }
        public int weight { get; set; }
        public int Price { get; set; }
    }
    public class TypesOfwheats
    {
        public int Name { get; set; }
        public int weight { get; set; }
        public int Price { get; set; }

    }
}
