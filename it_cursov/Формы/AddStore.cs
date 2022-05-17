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
    public partial class AddStore : Form
    {
        UserContext db;
        public AddStore()
        {
            InitializeComponent();
            db = new UserContext();
        }

        private void AddStore_Load(object sender, EventArgs e)
        {
            //AddStore addStore = new AddStore();
            // из команд в бд формируем список
            List<City> cities = db.Cities.ToList();
            comboBox1.DataSource = cities;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
      

            Store Store = new Store();

            Store.Name = textBox1.Text;
            Store.Address = textBox2.Text;
            Store.Schedule = maskedTextBox1.Text;
            Store.City = (City)comboBox1.SelectedItem;
            
            db.Stores.Add(Store);

            db.SaveChanges();
            MessageBox.Show("Добавлен!", "Успех");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
