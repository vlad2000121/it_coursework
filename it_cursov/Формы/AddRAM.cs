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
    public partial class AddRAM : Form
    {
        UserContext db;
        Form2 form2;
        public AddRAM()
        {
            InitializeComponent();
            db = new UserContext();
        }

        private void AddRAM_Load(object sender, EventArgs e)
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
            RAM rAM = new RAM();
            rAM.name = textBox1.Text;
            rAM.memory_size = textBox2.Text;
            rAM.memory_type = textBox3.Text;
            rAM.frequency = textBox4.Text;
            rAM.CL = Convert.ToInt32(textBox5.Text);
           
            rAM.kol = Convert.ToInt32(textBox7.Text);
            rAM.price = Convert.ToInt32(textBox8.Text);
            rAM.Store = (Store)comboBox1.SelectedItem;

            db.RAMs.Add(rAM);

            db.SaveChanges();
            MessageBox.Show("Добавлен!", "Успех");

        }
    }
}
