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
    public partial class AddCorpus : Form
    {
        UserContext db;
        Form2 form2;
        private int Id;
        public AddCorpus(int id)
        {
            InitializeComponent();
            db = new UserContext();
        }
     
        private void AddCorpus_Load(object sender, EventArgs e)
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

            Corpus corpus = new Corpus();
            corpus.name = textBox1.Text;
            corpus.frame_size = textBox2.Text;
            corpus.form_factor = textBox3.Text;
            corpus.fans = checkBox1.Checked;
            corpus.color = textBox4.Text;
            corpus.connectors = Convert.ToInt32(textBox5.Text);
            corpus.kol = Convert.ToInt32(textBox7.Text);
            corpus.price = Convert.ToInt32(textBox8.Text);
            corpus.Store = (Store)comboBox1.SelectedItem;
            
           
            db.Corpus.Add(corpus);

            db.SaveChanges();
            MessageBox.Show("Добавлен!", "Успех");
        }

    }   
}
