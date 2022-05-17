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
using it_cursov.Context;

namespace it_cursov.Формы
{
    public partial class Zakazs : Form
    {
        UserContext db;
        private int level;
        public Zakazs(int _level)
        {
            InitializeComponent();
            db = new UserContext();
            level = _level;
        }

  

        private void Zakazs_Load(object sender, EventArgs e)
        {
                db.Zakazs.Load();
          
            dataGridView1.DataSource = db.Zakazs.Local.ToBindingList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (level == 1)
            {

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
                MessageBox.Show("Заказ удален");
                db.SaveChanges();

            }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору", "Уведомление"); }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength >= 1)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox2.Text.ToLower()))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                //   dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                break;
                            }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.CurrentCell.ColumnIndex.ToString()); // столбец (процессор мат плата)
            //MessageBox.Show(dataGridView1.CurrentCell.RowIndex.ToString());    // строка(название)
            //     MessageBox.Show(db.Zakazs.ToString());
            //  MessageBox.Show(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString());
            try
            {
                string name_zakaz = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
                int n = 0;

                var procs = db.Procs;
                var matPlatas = db.MatPlatas;
                var corpus = db.Corpus;
                var graphics = db.GraphicsCards;
                var rAMs = db.RAMs;
                var storages = db.StorageDevices;
                var powers = db.PowerSupplies;

                if (dataGridView1.CurrentCell.ColumnIndex == 3) // Процессор
                {
                    foreach (Proc p in procs)
                    {
                        if (p.name == name_zakaz && n == 0)
                        {
                            MessageBox.Show(Proc.TextOut(p), "Харатеристика");
                            n++;
                        }
                    }

                }
                else
                if (dataGridView1.CurrentCell.ColumnIndex == 4) // материнская поата
                {
                    foreach (MatPlata m in matPlatas)
                    {
                        if (m.name == name_zakaz && n == 0)
                        {
                            MessageBox.Show(MatPlata.TextOut(m), "Харатеристика");
                            n++;
                        }
                    }
                }
                else
                if (dataGridView1.CurrentCell.ColumnIndex == 5) //корпус
                {
                    foreach (Corpus c in corpus)
                    {
                        if (c.name == name_zakaz && n == 0)
                        {
                            MessageBox.Show(it_cursov.Corpus.TextOut(c),"Характеристика" );
                            n++;
                        }
                    }
                }
                else
                if (dataGridView1.CurrentCell.ColumnIndex == 6) //видеокарта
                {
                    foreach (GraphicsCard g in graphics)
                    {
                        if (g.name == name_zakaz && n == 0)
                        {
                            MessageBox.Show(GraphicsCard.TextOut(g), "Харатеристика");
                            n++;
                        }
                    }
                }
                else
                if (dataGridView1.CurrentCell.ColumnIndex == 7) //Озу
                {
                    foreach (RAM r in rAMs)
                    {
                        if (r.name == name_zakaz && n == 0)
                        {
                            MessageBox.Show(RAM.TextOut(r), "Харатеристика");
                            n++;
                        }
                    }
                }
                else
                if (dataGridView1.CurrentCell.ColumnIndex == 8) //накопитель
                {
                    foreach (StorageDevice s in storages)
                    {
                        if (s.name == name_zakaz && n == 0)
                        {
                            MessageBox.Show(StorageDevice.TextOut(s), "Харатеристика");
                            n++;
                        }
                    }
                }
                else
                if (dataGridView1.CurrentCell.ColumnIndex == 9) //блок питания
                {
                    foreach (PowerSupply p in powers)
                    {
                        if (p.name == name_zakaz && n == 0)
                        {
                            MessageBox.Show(PowerSupply.TextOut(p), "Харатеристика");
                            n++;
                        }
                    }
                }

            }
            catch 
            { MessageBox.Show("Возникла ошибка! Возможно выделенное поле является пустым","ОШИБКА"); }
            //Proc proc1 = db.Procs.FirstOrDefault(p => p.Name == "Bob");
            //if (proc1 != null)
            //{
            //    db.Users.Load(proc1);
            //    db.SaveChanges();
            //}

        }
    }
}
