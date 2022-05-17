using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_cursov.Context
{
    class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Store> Stores { get; set; }
        public City()
        {
            Stores = new List<Store>();
        }
    }
}
