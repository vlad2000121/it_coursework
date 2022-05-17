using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_cursov.Context
{
    class Store
    {
       // internal object comboBox1;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Schedule { get; set; }//график работы

        public int? CityId { get; set; }
        public City City { get; set; }




        public ICollection<Corpus> Corpus { get; set; }
        public ICollection<MatPlata> MatPlatas { get; set; }
        public ICollection<PowerSupply> PowerSupplies { get; set; }
        public ICollection<Proc> Procs { get; set; }
        public ICollection<RAM> RAMs { get; set; }
        public ICollection<StorageDevice> storageDevices { get; set; }
        public ICollection<GraphicsCard> GraphicsCards { get; set; }
        public Store()
        {
            Corpus = new List<Corpus>();
            GraphicsCards = new List<GraphicsCard>();
            MatPlatas = new List<MatPlata>();
            PowerSupplies = new List<PowerSupply>();
            Procs = new List<Proc>();
            RAMs = new List<RAM>();
            storageDevices = new List<StorageDevice>();
        }


    }
}
