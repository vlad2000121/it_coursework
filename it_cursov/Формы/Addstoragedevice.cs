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
    public partial class Addstoragedevice : Form
    {
        UserContext db;
        Form2 form2;
        public Addstoragedevice()
        {
            InitializeComponent();
            db = new UserContext();
        }

        private void Addstoragedevice_Load(object sender, EventArgs e)
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
            StorageDevice storageDevice = new StorageDevice();
            storageDevice.name = textBox1.Text;
            storageDevice.memory_size = textBox3.Text;
            storageDevice.memory_type = textBox2.Text;
            storageDevice.speed = Convert.ToInt32(textBox5.Text);
            storageDevice.TBW = Convert.ToInt32(textBox4.Text);

            storageDevice.kol = Convert.ToInt32(textBox7.Text);
            storageDevice.price = Convert.ToInt32(textBox8.Text);
            storageDevice.Store = (Store)comboBox1.SelectedItem;

            db.StorageDevices.Add(storageDevice);

            db.SaveChanges();
            MessageBox.Show("Добавлен!", "Успех");
        }
    }
}
