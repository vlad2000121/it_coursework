using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_cursov
{
    public partial class SelectionCity : Form
    {
        private int level;
        public SelectionCity(int _level)
        {
            InitializeComponent();
            level = _level;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Запоминаем Белгород
            string iCity = "Белгород";
            // Инициализируем форму со всеми аптеками выбранного 
            // города и передаем в форму город
            SelectionStore form = new SelectionStore(iCity,level);
            // Показываем форму
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Запоминаем Белгород
            string iCity = "Белгород";
            // Инициализируем форму со всеми аптеками выбранного 
            // города и передаем в форму город
            SelectionStore form = new SelectionStore(iCity, level);
            // Показываем форму
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Запоминаем Белгород
            string iCity = "Воронеж";
            // Инициализируем форму со всеми аптеками выбранного 
            // города и передаем в форму город
            SelectionStore form = new SelectionStore(iCity, level);
            // Показываем форму
            form.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Запоминаем Белгород
            string iCity = "Воронеж";
            // Инициализируем форму со всеми аптеками выбранного 
            // города и передаем в форму город
            SelectionStore form = new SelectionStore(iCity, level);
            // Показываем форму
            form.Show();
        }
    }
}
