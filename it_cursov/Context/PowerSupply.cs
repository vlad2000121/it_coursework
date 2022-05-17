using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_cursov.Context
{
    class PowerSupply
    {
        public int Id { get; set; }
       
        public string name { get; set; }   //наименование
        public int Power { get; set; }  //Мощность 
        public string сooling_system { get; set; }  //Система охлаждения
        public string backlight_type { get; set; }   //Тип подсветки

        public int kol { get; set; } //количество
        public int price { get; set; } //цена



        public int? StoreId { get; set; }
        public Store Store { get; set; }

        public int? ZakazId { get; set; }
        public Zakaz zakaz { get; set; }

        static public string TextOut(PowerSupply n)
        {
            string s = $"Наименование: '{n.name}',\n Мощность: '{n.Power}',\n Система охлаждения: '{n.сooling_system}',\n Тип подсветки: '{n.backlight_type}',\n Цена: '{n.price}'";
            return s;
        }
    }
}
