using it_cursov.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_cursov
{
    class GraphicsCard
    {
        public int Id { get; set; }
        public string name { get; set; }   //наименование
        public string memory_size { get; set; }   //Объем видеопамяти
        public string memory_type { get; set; }  //Тип памяти

        public string bus_width { get; set; }  //Разрядность шины

        public string microarchitecture { get; set; } //количество ядер
       
        public string connectors { get; set; } //разъемы 
        public int TDP { get; set; } //тепловыделение
        
        public int kol { get; set; } //количество
        public int price { get; set; } //цена



        public int? StoreId { get; set; }
        public Store Store { get; set; }


        public int? ZakazId { get; set; }
        public Zakaz zakaz { get; set; }


        static public string TextOut(GraphicsCard n)
        {
            string s = $"Наименование: '{n.name}',\n Объем видеопамяти: '{n.memory_size}',\n Тип памяти: '{n.memory_type}',\n Разрядность шины: '{n.bus_width}',\n Количество ядер: '{n.microarchitecture}',\n Тепловыделение: '{n.TDP}',\n Цена: '{n.price}'";
            return s;
        }

    }
}
