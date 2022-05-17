using it_cursov.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_cursov
{
    class MatPlata
    {
        public int Id { get; set; }
        public string name { get; set; }   //наименование
        public string socket { get; set; }   //сокет
        public int number_ram { get; set; } //количество оперативной памяти
        public string chip { get; set; } //чипсет
        public bool SSD_m2 { get; set; } // SSD
        public int kol { get; set; } //количество
        public int price { get; set; } //цена



        public int? StoreId { get; set; }
        public Store Store { get; set; }


        public int? ZakazId { get; set; }
        public Zakaz zakaz { get; set; }



        static public string TextOut(MatPlata n)
        {
            string s = $"Наименование: '{n.name}',\n Сокет: '{n.socket}',\n Количесвто ОЗУ: '{n.number_ram}',\n Чипсет: '{n.chip}',\n SSD M.2: '{n.SSD_m2}',\n  Цена: '{n.price}'";
            return s;
        }
    }
}
