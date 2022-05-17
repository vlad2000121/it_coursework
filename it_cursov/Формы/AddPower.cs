using System;
using it_cursov.Context;
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
    public partial class AddPower : Form
    {
        UserContext db;
        Form2 form2;
        public AddPower()
        {
            InitializeComponent();
            db = new UserContext();
        }

        private void AddPower_Load(object sender, EventArgs e)
        {
            form2 = this.Owner as Form2;
            if (form2 == null)
            {
                throw new Exception("Ошибка");
            }

            List<Store> stores = db.Stores.ToList();
            comboBox1.DataSource = stores;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PowerSupply powerSupply = new PowerSupply();
            powerSupply.name = textBox1.Text;
            powerSupply.Power = Convert.ToInt32(textBox3.Text);
            powerSupply.сooling_system = textBox2.Text;
            powerSupply.backlight_type =textBox5.Text;
      

            powerSupply.kol = Convert.ToInt32(textBox7.Text);
            powerSupply.price = Convert.ToInt32(textBox8.Text);
            powerSupply.Store = (Store)comboBox1.SelectedItem;

            db.PowerSupplies.Add(powerSupply);

            db.SaveChanges();
            MessageBox.Show("Добавлен!", "Успех");
        }
    }
}
