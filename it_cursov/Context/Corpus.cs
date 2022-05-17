using it_cursov.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_cursov
{
    class Corpus
    {
        public int Id { get; set; }
        public string name { get; set; }   //наименование
        public string frame_size { get; set; }   //Типоразмер корпуса
        public string form_factor { get; set; }  //Форм-фактор       
        public bool fans { get; set; }  //Вентиляторы в комплекте(да/нет)
        public string color { get; set; } //Основной цвет
        public int connectors { get; set; } //Разъемы
        public int kol { get; set; } //количество
        public int price { get; set; } //цена



        public int? StoreId { get; set; }
        public Store Store { get; set; }


        public int? ZakazId { get; set; }
        public Zakaz zakaz { get; set; }


        static public string TextOut(Corpus n)
        {
            string s = $"Наименование: '{n.name}',\n Типоразмер корпуса: '{n.frame_size}',\n Форм-фактор: '{n.form_factor}',\n Вентиляторы: '{n.fans}',\n Кол. разьемов: '{n.connectors}',\n Цена: '{n.price}'";
            return s;
        }
    }
}
