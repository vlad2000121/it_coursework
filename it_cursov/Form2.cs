using it_cursov.Формы;
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

namespace it_cursov
{
    public partial class Form2 : Form
    {
        UserContext db;
        private int Id;
        private int level;
        public Form2(int id,int _level)
        {
            InitializeComponent();
            db = new UserContext();
            Id = id;
            level = _level;
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            if (level == 1) label8.Text = "Администратор";
            else if (level == 2) label8.Text = "Сотрудник";
            else if (level == 3) label8.Text = "Пользователь";

            db.Users.Load();

            db.Procs.Load();
            db.MatPlatas.Load();
            db.Corpus.Load();
            db.GraphicsCards.Load();
            db.RAMs.Load();
            db.StorageDevices.Load();
            db.PowerSupplies.Load();
            dataGridView1.DataSource = db.Procs.Local.ToBindingList();
            dataGridView2.DataSource = db.MatPlatas.Local.ToBindingList();
            dataGridView3.DataSource = db.Corpus.Local.ToBindingList();
            dataGridView4.DataSource = db.GraphicsCards.Local.ToBindingList();
            dataGridView5.DataSource = db.RAMs.Local.ToBindingList();
            dataGridView6.DataSource = db.StorageDevices.Local.ToBindingList();
            dataGridView7.DataSource = db.PowerSupplies.Local.ToBindingList();


            // это уберем и будет отображаться весь список комплектующих
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.ClearSelection();
            dataGridView5.ClearSelection();
            dataGridView6.ClearSelection();
            dataGridView7.ClearSelection();


            string k = Convert.ToString(Id);
            var values = k.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);


            dataGridView1.CurrentCell = null;
            dataGridView2.CurrentCell = null;
            dataGridView3.CurrentCell = null;
            dataGridView4.CurrentCell = null;
            dataGridView5.CurrentCell = null;
            dataGridView6.CurrentCell = null;
            dataGridView7.CurrentCell = null;
        
                //dataGridView1
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    foreach (string value in values)
                    {
                        var row = dataGridView1.Rows[i];
                        row.Visible = false;
                        if (
                            row.Cells[11].Value.ToString().Contains(value))
                        {
                            row.Visible = true;

                        }
                    }
                }
                dataGridView1.Refresh(); // обновляем грид

                //dataGridView2
                for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                {
                    foreach (string value in values)
                    {
                        var row2 = dataGridView2.Rows[i];
                        row2.Visible = false;
                        if (
                            row2.Cells[8].Value.ToString().Contains(value))
                        {
                            row2.Visible = true;

                        }
                    }
                }
                dataGridView2.Refresh(); // обновляем грид

                //dataGridView3

                for (int i = 0; i < dataGridView3.RowCount - 1; i++)
                {
                    foreach (string value in values)
                    {
                        var row3 = dataGridView3.Rows[i];
                        row3.Visible = false;
                        if (
                            row3.Cells[9].Value.ToString().Contains(value))
                        {
                            row3.Visible = true;

                        }
                    }
                }
                dataGridView3.Refresh(); // обновляем грид

                //dataGridView4
                for (int i = 0; i < dataGridView4.RowCount - 1; i++)
                {
                    foreach (string value in values)
                    {
                        var row4 = dataGridView4.Rows[i];
                        row4.Visible = false;
                        if (
                            row4.Cells[10].Value.ToString().Contains(value))
                        {
                            row4.Visible = true;

                        }
                    }
                }

                dataGridView4.Refresh(); // обновляем грид
                                         //dataGridView5
                for (int i = 0; i < dataGridView5.RowCount - 1; i++)
                {
                    foreach (string value in values)
                    {
                        var row5 = dataGridView5.Rows[i];
                        row5.Visible = false;
                        if (
                            row5.Cells[8].Value.ToString().Contains(value))
                        {
                            row5.Visible = true;

                        }
                    }
                }
                dataGridView5.Refresh(); // обновляем грид
                                         //dataGridView6
                for (int i = 0; i < dataGridView6.RowCount - 1; i++)
                {
                    foreach (string value in values)
                    {
                        var row6 = dataGridView6.Rows[i];
                        row6.Visible = false;
                        if (
                            row6.Cells[8].Value.ToString().Contains(value))
                        {
                            row6.Visible = true;

                        }
                    }
                }
                dataGridView6.Refresh(); // обновляем грид
                                         //dataGridView7
                for (int i = 0; i < dataGridView7.RowCount - 1; i++)
                {
                    foreach (string value in values)
                    {
                        var row7 = dataGridView7.Rows[i];
                        row7.Visible = false;
                        if (
                            row7.Cells[7].Value.ToString().Contains(value))
                        {
                            row7.Visible = true;

                        }
                    }
                }
                dataGridView7.Refresh(); // обновляем грид
               
            

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (level < 3)
            {

                AddProc addProc = new AddProc();
                addProc.Owner = this;


                addProc.Show();
            }
            else { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }
            
            //db.Procs.Load();
            //dataGridView1.DataSource = db.Procs.Local.ToBindingList();
     

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            Form2_Load(sender,e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength >= 1)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                //   dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                break;
                            }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (level < 3)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("Компонент удален");
            db.SaveChanges();
                Form2_Load(sender, e);

            }
            else 
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }


        }


        //КОРЗИНА
        public string komponent_name;
        public string komponent_price;
        public int komponent_kol;
        public string komponent_soket;
        public int komponent_TDP;

        public int komponent_IDstore;

        private void button4_Click(object sender, EventArgs e)
        {
            Korzina f = new Korzina();
            f.Owner = this;

           

            komponent_name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            komponent_price=  dataGridView1.CurrentRow.Cells[10].Value.ToString();
            komponent_kol = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            komponent_soket = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            komponent_TDP = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            komponent_IDstore = Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value.ToString());
            // добавить переменные которые будем сравнивать для соместимости сборки

        }

        private void добавитьВКорзинуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьКорзинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korzina korzina = new Korzina();
            korzina.Owner = this;


            korzina.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (level < 3)
            {

                AddMatPlat addMatPlat = new AddMatPlat();
            addMatPlat.Owner = this;


            addMatPlat.Show();

        }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }

}

private void button7_Click(object sender, EventArgs e)
        {
            if (level < 3)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("Компонент удален");
            db.SaveChanges();
                Form2_Load(sender, e);
            }
            else 
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }
        
        public string komponent_name2;
        public string komponent_price2;
        public int komponent_kol2;
        public string komponent_soket2;
        public string komponent_ram;
        private void button5_Click(object sender, EventArgs e)
        {
            Korzina f = new Korzina();
            f.Owner = this;

            komponent_name2 = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            komponent_price2 = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            komponent_kol2 = Convert.ToInt32(dataGridView2.CurrentRow.Cells[6].Value.ToString());
            komponent_soket2 = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            komponent_ram = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            // добавить переменные которые будем сравнивать для соместимости сборки
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength >= 1)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                            if (dataGridView2.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox2.Text.ToLower()))
                            {
                                dataGridView2.Rows[i].Selected = true;
                                //   dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                break;
                            }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (level < 3)
            {
                AddCorpus addCorpus = new AddCorpus(Id);
                addCorpus.Owner = this;


                addCorpus.Show();
            }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (level < 3)
            {
                foreach (DataGridViewRow row in dataGridView3.SelectedRows)
                {
                    dataGridView3.Rows.RemoveAt(row.Index);
                }
                MessageBox.Show("Компонент удален");
                db.SaveChanges();
                Form2_Load(sender, e);

            }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }
        public string komponent_name3;
        public string komponent_price3;
        public int komponent_kol3;
        private void button9_Click(object sender, EventArgs e)
        {
            Korzina f = new Korzina();
            f.Owner = this;

            komponent_name3 = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            komponent_price3 = dataGridView3.CurrentRow.Cells[8].Value.ToString();
            komponent_kol3 = Convert.ToInt32(dataGridView3.CurrentRow.Cells[7].Value.ToString());
            // добавить переменные которые будем сравнивать для соместимости сборки
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength >= 1)
            {
                for (int i = 0; i < dataGridView3.RowCount; i++)
                {
                    dataGridView3.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView3.ColumnCount; j++)
                        if (dataGridView3.Rows[i].Cells[j].Value != null)
                            if (dataGridView3.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox3.Text.ToLower()))
                            {
                                dataGridView3.Rows[i].Selected = true;
                                //   dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                break;
                            }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (level < 3)
            {
                AddVideo addVideo = new AddVideo();
            addVideo.Owner = this;


            addVideo.Show();

        }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }
}

        private void button15_Click(object sender, EventArgs e)
        {
            if (level < 3)
            {
                foreach (DataGridViewRow row in dataGridView4.SelectedRows)
            {
                dataGridView4.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("Компонент удален");
            db.SaveChanges();
                Form2_Load(sender, e);

            }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        public string komponent_name4;
        public string komponent_price4;
        public int komponent_kol4;
        public int komponent_TDP2;
        private void button13_Click(object sender, EventArgs e)
        {
            Korzina f = new Korzina();
            f.Owner = this;

            komponent_name4 = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            komponent_price4 = dataGridView4.CurrentRow.Cells[9].Value.ToString();
            komponent_kol4 = Convert.ToInt32(dataGridView4.CurrentRow.Cells[8].Value.ToString());
            komponent_TDP2 = Convert.ToInt32(dataGridView4.CurrentRow.Cells[7].Value.ToString());
            // добавить переменные которые будем сравнивать для соместимости сборки
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.TextLength >= 1)
            {
                for (int i = 0; i < dataGridView4.RowCount; i++)
                {
                    dataGridView4.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView4.ColumnCount; j++)
                        if (dataGridView4.Rows[i].Cells[j].Value != null)
                            if (dataGridView4.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox4.Text.ToLower()))
                            {
                                dataGridView4.Rows[i].Selected = true;
                                //   dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                break;
                            }
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (level < 3)
            {
                AddRAM addRAM = new AddRAM();
            addRAM.Owner = this;


            addRAM.Show();
        }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }
}

        private void button19_Click(object sender, EventArgs e)
        {
            if (level < 3)
            {
                foreach (DataGridViewRow row in dataGridView5.SelectedRows)
            {
                dataGridView5.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("Компонент удален");
            db.SaveChanges();
                Form2_Load(sender, e);
            }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        public string komponent_name5;
        public string komponent_price5;
        public int komponent_kol5;
        private void button17_Click(object sender, EventArgs e)
        {
            Korzina f = new Korzina();
            f.Owner = this;

            komponent_name5 = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            komponent_price5 = dataGridView5.CurrentRow.Cells[7].Value.ToString();
            komponent_kol5 = Convert.ToInt32(dataGridView5.CurrentRow.Cells[6].Value.ToString());
            // добавить переменные которые будем сравнивать для соместимости сборки
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.TextLength >= 1)
            {
                for (int i = 0; i < dataGridView5.RowCount; i++)
                {
                    dataGridView5.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView5.ColumnCount; j++)
                        if (dataGridView5.Rows[i].Cells[j].Value != null)
                            if (dataGridView5.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox5.Text.ToLower()))
                            {
                                dataGridView5.Rows[i].Selected = true;
                                //   dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                break;
                            }
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (level < 3)
            {
                Addstoragedevice addstoragedevice = new Addstoragedevice();
            addstoragedevice.Owner = this;


            addstoragedevice.Show();
        }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }
}

        private void button23_Click(object sender, EventArgs e)
        {
            if (level < 3)
            {
                foreach (DataGridViewRow row in dataGridView6.SelectedRows)
            {
                dataGridView6.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("Компонент удален");
            db.SaveChanges();
                Form2_Load(sender, e);
            }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        public string komponent_name6;
        public string komponent_price6;
        public int komponent_kol6;
     
        private void button21_Click(object sender, EventArgs e)
        {
            Korzina f = new Korzina();
            f.Owner = this;

            komponent_name6 = dataGridView6.CurrentRow.Cells[1].Value.ToString();
            komponent_price6 = dataGridView6.CurrentRow.Cells[7].Value.ToString();
            komponent_kol6 = Convert.ToInt32(dataGridView6.CurrentRow.Cells[7].Value.ToString());
        
            // добавить переменные которые будем сравнивать для соместимости сборки
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.TextLength >= 1)
            {
                for (int i = 0; i < dataGridView6.RowCount; i++)
                {
                    dataGridView6.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView6.ColumnCount; j++)
                        if (dataGridView6.Rows[i].Cells[j].Value != null)
                            if (dataGridView6.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox6.Text.ToLower()))
                            {
                                dataGridView6.Rows[i].Selected = true;
                                //   dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                break;
                            }
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (level < 3)
            {
                AddPower addPower = new AddPower();
            addPower.Owner = this;


            addPower.Show();
        }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }
}

        private void button27_Click(object sender, EventArgs e)
        {
            if (level < 3)
            {
                foreach (DataGridViewRow row in dataGridView7.SelectedRows)
            {
                dataGridView7.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("Компонент удален");
            db.SaveChanges();
                Form2_Load(sender, e);
            }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору и Сотрудникам", "Уведомление"); }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        public string komponent_name7;
        public string komponent_price7;
        public int komponent_kol7; 
        public int komponent_power;
        private void button25_Click(object sender, EventArgs e)
        {
            Korzina f = new Korzina();
            f.Owner = this;

            komponent_name7 = dataGridView7.CurrentRow.Cells[1].Value.ToString();
            komponent_price7 = dataGridView7.CurrentRow.Cells[6].Value.ToString();
            komponent_kol7 = Convert.ToInt32(dataGridView7.CurrentRow.Cells[5].Value.ToString());
            komponent_power = Convert.ToInt32(dataGridView7.CurrentRow.Cells[2].Value.ToString());
            // добавить переменные которые будем сравнивать для соместимости сборки
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.TextLength >= 1)
            {
                for (int i = 0; i < dataGridView7.RowCount; i++)
                {
                    dataGridView7.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView7.ColumnCount; j++)
                        if (dataGridView7.Rows[i].Cells[j].Value != null)
                            if (dataGridView7.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox7.Text.ToLower()))
                            {
                                dataGridView7.Rows[i].Selected = true;
                                //   dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                break;
                            }
                }
            }
        }

        private void учетныеЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (level == 1) { 
            Users u = new Users();
            u.Owner = this;
            u.Show();
        }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору", "Уведомление"); }
}

        private void списокГородовToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                AddStore addStore = new AddStore();
            addStore.Show();
            }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору", "Уведомление"); }
        }

      

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2_Load(sender, e);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение 'Компьютерных комплектующих'.\n" +
             "Пользователь может добавлять, удалять, изменять обьекты по нажатию кнопки мышью.\n" +
             "Так же предусмотренна возможность поиска обьекта.\n" +

             "Создана вкладка 'Корзина' для добавление и покупки необходимых компонентов. \n"

             , "Справка");
        }

        private void списокЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (level < 3 )
            {
                Zakazs z = new Zakazs(level);
                z.Owner = this;
                z.Show(); 
            }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору", "Уведомление"); }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }
    }
}
