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
    public partial class AddMatPlat : Form
    {
        UserContext db;
        Form2 form2;
        public AddMatPlat()
        {
            InitializeComponent();
            db = new UserContext();
        }

            private void AddMatPlat_Load(object sender, EventArgs e)
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
            MatPlata matPlata = new MatPlata();
            matPlata.name = textBox1.Text;
            matPlata.socket = textBox2.Text;
            matPlata.number_ram = Convert.ToInt32(textBox3.Text);
            matPlata.chip = textBox4.Text;
            matPlata.SSD_m2 = checkBox1.Checked;
            matPlata.kol = Convert.ToInt32(textBox7.Text);
            matPlata.price = Convert.ToInt32(textBox8.Text);
            matPlata.Store = (Store)comboBox1.SelectedItem;

            db.MatPlatas.Add(matPlata);

            db.SaveChanges();
            MessageBox.Show("Добавлен!", "Успех");
        }

       
    }
}
