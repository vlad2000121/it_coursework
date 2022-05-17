using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it_cursov.Формы
{
    public partial class Users : Form
    {
        UserContext db;
        public Users()
        {
            InitializeComponent();
            db = new UserContext();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            db.Users.Load();
            dataGridView1.DataSource = db.Users.Local.ToBindingList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("Пользователь удален");
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // string k= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //int level = Convert.ToInt32(k) + 1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                User users = db.Users.Find(id);

                if ( users.Level == 2 || users.Level==3)
                {
                    users.Level--;
                    MessageBox.Show("Объект обновлен", "Сообщение");
                }
                else {
                    MessageBox.Show("Пользователь наделен максимальными правами(Администратор)", "Сообщение");
                }
                //AddUsers uForm = new AddUsers();

                //uForm.textBox1.Text = users.;
                
                //plForm.numericUpDown1.Value = player.Age;
                //plForm.comboBox1.SelectedItem = player.Position;
                //plForm.textBox1.Text = player.Name;



                db.SaveChanges();
                dataGridView1.Refresh(); // обновляем грид
               
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                User users = db.Users.Find(id);

                if (users.Level == 2 || users.Level == 1)
                {
                    users.Level++;
                    MessageBox.Show("Объект обновлен","Сообщение");
                }
                else
                {
                    MessageBox.Show("Пользователь наделен минимальными правами", "Сообщение");
                }
                //AddUsers uForm = new AddUsers();

                //uForm.textBox1.Text = users.;

                //plForm.numericUpDown1.Value = player.Age;
                //plForm.comboBox1.SelectedItem = player.Position;
                //plForm.textBox1.Text = player.Name;



                db.SaveChanges();
                dataGridView1.Refresh(); // обновляем грид

            }

        }
    }
}
