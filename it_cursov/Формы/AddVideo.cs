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
    public partial class AddVideo : Form
    {
        UserContext db;
        Form2 form2;
        public AddVideo()
        {
            InitializeComponent();
            db = new UserContext();
        }

        private void AddVideo_Load(object sender, EventArgs e)
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
            GraphicsCard graphicsCard = new GraphicsCard();
            graphicsCard.name = textBox1.Text;
            graphicsCard.memory_size = textBox2.Text;
            graphicsCard.memory_type = textBox3.Text;
            graphicsCard.bus_width = textBox4.Text;
            graphicsCard.microarchitecture = textBox5.Text;
            graphicsCard.connectors = textBox11.Text;
            graphicsCard.TDP = Convert.ToInt32(textBox10.Text);
            graphicsCard.kol = Convert.ToInt32(textBox7.Text);
            graphicsCard.price = Convert.ToInt32(textBox8.Text);
            graphicsCard.Store = (Store)comboBox1.SelectedItem;

            db.GraphicsCards.Add(graphicsCard);

            db.SaveChanges();
            MessageBox.Show("Добавлен!", "Успех");

        }
    }
}
