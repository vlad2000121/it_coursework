using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_cursov.Context
{
    class Zakaz
    {
        public int Id { get; set; }
        public int Number_Zakaz { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
       
        public int IdStore { get; set; }
        
        public string Corpus { get; set; }
        public string MatPlatas { get; set; }
        public string PowerSupplies { get; set; }
        public string Procs { get; set; }
        public string RAMs { get; set; }
        public string storageDevices { get; set; }
        public string GraphicsCards { get; set; }


        //public ICollection<Corpus> Corpus { get; set; }
        //public ICollection<MatPlata> MatPlatas { get; set; }
        //public ICollection<PowerSupply> PowerSupplies { get; set; }
        //public ICollection<Proc> Procs { get; set; }
        //public ICollection<RAM> RAMs { get; set; }
        //public ICollection<StorageDevice> storageDevices { get; set; }
        //public ICollection<GraphicsCard> GraphicsCards { get; set; }
       
        //public Zakaz()
        //{
        //    Corpus = new List<Corpus>();
        //    GraphicsCards = new List<GraphicsCard>();
        //    MatPlatas = new List<MatPlata>();
        //    PowerSupplies = new List<PowerSupply>();
        //    Procs = new List<Proc>();
        //    RAMs = new List<RAM>();
        //    storageDevices = new List<StorageDevice>();
        //}

    }
}
