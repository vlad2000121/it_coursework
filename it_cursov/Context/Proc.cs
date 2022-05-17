using it_cursov.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_cursov
{
    class Proc
    {
        public int Id { get; set; }
        public string name { get; set; }   //наименование
        public string socket { get; set; }   //сокет
        public int base_frequency { get; set; }  //базовая частота
        public bool free_multiplier { get; set; }  //свободный множитель
        public int number_of_cores { get; set; } //количество ядер
        public int cache_size { get; set; } //обьем кэша
        public int TDP { get; set; } //тепловыделение
        public bool Integ_graph_core { get; set; } // Интегрированное графическое ядро
        public int kol { get; set; } //количество
        public int price { get; set; } //цена



        public int? StoreId { get; set; }
        public Store Store { get; set; }

        public int? ZakazId { get; set; }
        public Zakaz zakaz { get; set; }


        static public string TextOut(Proc n)
        {
            string s = $" Наименование: '{n.name}',\n Сокет: '{n.socket}',\n Базовая частота: '{n.base_frequency}',\n Количество ядер: '{n.number_of_cores}',\n Тепловыделение: '{n.TDP}',\n Цена: '{n.price}'";
            return s;
        }

    }
}
