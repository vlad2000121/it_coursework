using it_cursov.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_cursov.Формы
{
    public partial class Korzina : Form
    {
        UserContext db;
        private int price;
        public Korzina()
        {
            InitializeComponent();
            db = new UserContext();
        }

        private void Korzina_Load(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            label1.Text = "Название: " + main.komponent_name + "    " + "Цена: " + main.komponent_price + " руб.";
            label2.Text = "Название: " + main.komponent_name2 + "    " + "Цена: " + main.komponent_price2 + " руб.";
            label3.Text = "Название: " + main.komponent_name3 + "    " + "Цена: " + main.komponent_price3 + " руб.";
            label4.Text = "Название: " + main.komponent_name4 + "    " + "Цена: " + main.komponent_price4 + " руб.";
            label5.Text = "Название: " + main.komponent_name5 + "    " + "Цена: " + main.komponent_price5 + " руб.";
            label6.Text = "Название: " + main.komponent_name6 + "    " + "Цена: " + main.komponent_price6 + " руб.";
            label7.Text = "Название: " + main.komponent_name7 + "    " + "Цена: " + main.komponent_price7 + " руб.";
            
            if (main.komponent_name == null || main.komponent_name == null) {
                label1.Text = "Добавьте в корзину ПРОЦЕССОР";
                label1.ForeColor = Color.Red;
            }
            if (main.komponent_name2 == null || main.komponent_name2 == null)
            {
                label2.Text = "Добавьте в корзину МАТЕРИНСКУЮ ПЛАТУ";
                label2.ForeColor = Color.Red;
            }
            if (main.komponent_name3 == null || main.komponent_name3 == null)
            {
                label3.Text = "Добавьте в корзину КОРПУС";
                label3.ForeColor = Color.Red;
            }
            if (main.komponent_name4 == null || main.komponent_name4 == null)
            {
                label4.Text = "Добавьте в корзину ВИДЕОКРАТУ";
                label4.ForeColor = Color.Red;
            }
            if (main.komponent_name5 == null || main.komponent_name5 == null)
            {
                label5.Text = "Добавьте в корзину ОЗУ";
                label5.ForeColor = Color.Red;
            }
            if (main.komponent_name6 == null || main.komponent_name6 == null)
            {
                label6.Text = "Добавьте в корзину ХРАНИЛИЩЕ ДАННЫХ";
                label6.ForeColor = Color.Red;
            }
            if (main.komponent_name7 == null || main.komponent_name7 == null)
            {
                label7.Text = "Добавьте в корзину БЛОК ПИТАНИЯ";
                label7.ForeColor = Color.Red;
            }

            
            numericUpDown1.Maximum = main.komponent_kol;
            numericUpDown2.Maximum = main.komponent_kol2;
            numericUpDown3.Maximum = main.komponent_kol3;
            numericUpDown4.Maximum = main.komponent_kol4;
            numericUpDown5.Maximum = main.komponent_kol5;
            numericUpDown6.Maximum = main.komponent_kol6;
            numericUpDown7.Maximum = main.komponent_kol7;
            int k = Convert.ToInt32(main.komponent_price) * Convert.ToInt32(numericUpDown1.Value) + Convert.ToInt32(main.komponent_price2) * Convert.ToInt32(numericUpDown2.Value) + Convert.ToInt32(main.komponent_price3) * Convert.ToInt32(numericUpDown3.Value) +
                Convert.ToInt32(main.komponent_price4) * Convert.ToInt32(numericUpDown4.Value) + Convert.ToInt32(main.komponent_price5) * Convert.ToInt32(numericUpDown5.Value) + Convert.ToInt32(main.komponent_price6) * Convert.ToInt32(numericUpDown6.Value) + Convert.ToInt32(main.komponent_price7) * Convert.ToInt32(numericUpDown7.Value);
            price = k;
            label8.Text = "Итого: " + Convert.ToString(k) + " руб.";


            if (main.komponent_name == null || main.komponent_name2 == null || main.komponent_name3 == null || main.komponent_name4 == null || main.komponent_name5 == null || main.komponent_name6 == null || main.komponent_name7 == null)
            {
                MessageBox.Show("Проблемы с совметимостью: указаны не все компоненты");
                label19.Text = "Проблемы с совметимостью: указаны не все компоненты";
                label19.ForeColor = Color.Red;
                label20.Text = null;
                label21.Text = null;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            int k = Convert.ToInt32(main.komponent_price) * Convert.ToInt32(numericUpDown1.Value) + Convert.ToInt32(main.komponent_price2) * Convert.ToInt32(numericUpDown2.Value) + Convert.ToInt32(main.komponent_price3) * Convert.ToInt32(numericUpDown3.Value) +
               Convert.ToInt32(main.komponent_price4) * Convert.ToInt32(numericUpDown4.Value) + Convert.ToInt32(main.komponent_price5) * Convert.ToInt32(numericUpDown5.Value) + Convert.ToInt32(main.komponent_price6) * Convert.ToInt32(numericUpDown6.Value) + Convert.ToInt32(main.komponent_price7) * Convert.ToInt32(numericUpDown7.Value);
            price = k;
            label8.Text = "Итого: " + Convert.ToString(k) + " руб.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            if (main.komponent_name == null || main.komponent_name2 == null || main.komponent_name3 == null || main.komponent_name4 == null || main.komponent_name5 == null || main.komponent_name6 == null || main.komponent_name7 == null)
            {
                MessageBox.Show("Проблемы с совметимостью: указаны не все компоненты");
                label19.Text = "Проблемы с совметимостью: указаны не все компоненты";
                label19.ForeColor = Color.Red;
                label20.Text = null;
                label21.Text = null;
            }
            else
            {

                if (main.komponent_soket == main.komponent_soket2)
                {
                    label19.Text = "Сокет совпадает";
                    label19.ForeColor = Color.Green;
                }
                else
                {
                    label19.Text = "Сокет не совпадает";
                    label19.ForeColor = Color.Red;
                }

                if (Convert.ToInt32(numericUpDown5.Value) <= Convert.ToInt32(main.komponent_ram))
                {
                    label20.Text = "Достаточно слотов оперативной памяти";
                    label20.ForeColor = Color.Green;
                }
                else
                {
                    label20.Text = "Недостаточно слотов оперативной памяти";
                    label20.ForeColor = Color.Red;
                }

                int TDP = (main.komponent_TDP + main.komponent_TDP2+100)*2;
                int power = main.komponent_power;
                if (power >= TDP)
                {
                    label21.Text = "Проблем с энергопотреблением нет";
                    label21.ForeColor = Color.Green;
                }
                else
                {
                    label21.Text = "Энергопотребление неоптимально";
                    label21.ForeColor = Color.Red;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            Zakaz zakaz = new Zakaz();
            Random x = new Random();
            int n = x.Next(100000, 9999999);
            zakaz.Number_Zakaz = n;
            zakaz.Name = main.komponent_name+" | "+ main.komponent_name2 + " | "+main.komponent_name3 + " | "+main.komponent_name4 + " | "+main.komponent_name5 + " | "+main.komponent_name6 + " | "+main.komponent_name7;
            zakaz.Price = price;
          
            zakaz.IdStore = main.komponent_IDstore;

            zakaz.Procs = main.komponent_name;
            zakaz.MatPlatas = main.komponent_name2;
            zakaz.Corpus = main.komponent_name3;
            zakaz.GraphicsCards = main.komponent_name4;
            zakaz.RAMs = main.komponent_name5;
            zakaz.storageDevices = main.komponent_name6;
            zakaz.PowerSupplies = main.komponent_name7;
       
            db.Zakazs.Add(zakaz);

            db.SaveChanges();
            MessageBox.Show("Добавлен! Номер вашего заказа: "+ n , "Заказ выполнен");
        }
    }
}


// сокет материнка и проц 
//количество оперативной памяти
// мощность блока питания

