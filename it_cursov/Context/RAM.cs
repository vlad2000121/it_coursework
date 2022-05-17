    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace it_cursov.Context
    {
        class RAM
        {
            public int Id { get; set; }
            public string name { get; set; }   //наименование
            public string memory_size { get; set; }   //Объем 
            public string memory_type { get; set; }  //Тип памяти
            public string frequency { get; set; }  //Тактовая частота
       
            public int CL { get; set; }  //Тайминги

            public int kol { get; set; } //количество
            public int price { get; set; } //цена




            public int? StoreId { get; set; }
            public Store Store { get; set; }

        public int? ZakazId { get; set; }
        public Zakaz zakaz { get; set; }

        static public string TextOut(RAM n)
        {
            string s = $" Наименование: '{n.name}',\n Объем: '{n.memory_size}',\n Тип памяти: '{n.memory_type}',\n Тайминги: '{n.CL}',\n Цена: '{n.price}'";
            return s;
        }

    }
    }
