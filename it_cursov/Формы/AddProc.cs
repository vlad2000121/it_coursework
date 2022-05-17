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
    public partial class AddProc : Form
    {
        UserContext db;
        Form2 form2;
        public AddProc()
        {
            InitializeComponent();
            db = new UserContext();

        }
        private void AddProc_Load(object sender, EventArgs e)
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

            Proc proc = new Proc();
            proc.name = textBox1.Text;
            proc.socket = textBox2.Text;
            proc.base_frequency = Convert.ToInt32(textBox3.Text);
            proc.free_multiplier = checkBox1.Checked;
            proc.number_of_cores = Convert.ToInt32(textBox4.Text);
            proc.cache_size = Convert.ToInt32(textBox5.Text);
            proc.TDP = Convert.ToInt32(textBox6.Text);
            proc.Integ_graph_core = checkBox2.Checked;
            proc.kol = Convert.ToInt32(textBox7.Text);
            proc.price = Convert.ToInt32(textBox8.Text);
            proc.Store = (Store)comboBox1.SelectedItem;


            db.Procs.Add(proc);

            db.SaveChanges();
            MessageBox.Show("Добавлен!", "Успех");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
