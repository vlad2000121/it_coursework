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
    public partial class SelectionStore : Form
    {
        private UserContext db;
        private string iCity;
        private int level;
        public SelectionStore(string _iCity, int _level)
        {
            InitializeComponent();
            iCity = _iCity;
            level = _level;
            db = new UserContext();

        }



        private void SelectionStore_Load(object sender, EventArgs e)
        {
            db.Stores.Load();
            dataGridView1.DataSource = db.Stores.Local.ToBindingList();


            dataGridView1.ClearSelection();


            string k="2";
            if (iCity == "Белгород") k = "2";
            if (iCity == "Воронеж") k = "1";


            var values = k.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);


            dataGridView1.CurrentCell = null;

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                foreach (string value in values)
                {
                    var row = dataGridView1.Rows[i];

                    if ( row.Cells[4].Value.ToString().Contains(value))
                    {
                        row.Visible = false;

                    }
                }
            }

            //}
            //DataTable dtAuthTypes = new DataTable();
            //dtAuthTypes.Columns.Add("ID", typeof(int));
            //dtAuthTypes.Columns.Add("Type", typeof(string));

            //DataRow row1 = dtAuthTypes.NewRow();
            //row1["ID"] = 1;
            //row1["Type"] = "Аутентификация SQL Server";
            //dtAuthTypes.Rows.Add(row1);

            //DataRow row2 = dtAuthTypes.NewRow();
            //row2["ID"] = 2;
            //row2["Type"] = "Аутентификация Windows";
            //dtAuthTypes.Rows.Add(row2);

            //comboBox1.DataSource = dtAuthTypes;
            //comboBox1.DisplayMember = "Type";
            //comboBox1.ValueMember = "ID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {

                AddStore addStore = new AddStore();
            addStore.Show();
            }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору", "Уведомление"); }
        }

      

        //private void button2_Click(object sender, EventArgs e)
        //{
    
        
            
            
        //    // отображает магазины по id города

        //     dataGridView1.ClearSelection();

           
        //    string k = "2";
        //    var values = k.Split(new char[] { ' ' },
        //        StringSplitOptions.RemoveEmptyEntries);
           

        //    dataGridView1.CurrentCell = null;

        //    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
        //    {
        //        foreach (string value in values)
        //        {
        //            var row = dataGridView1.Rows[i];

        //            if (
        //                row.Cells["CityId"].Value.ToString().Contains(value))
        //            {
        //                row.Visible = false;

        //            }
        //        }
        //    }
  
           

        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            // отображает магазины по id города с учетом текст бокса

            //dataGridView1.ClearSelection();

            //if (string.IsNullOrWhiteSpace(textBox1.Text))
            //    return;

            //var values = textBox1.Text.Split(new char[] { ' ' },
            //    StringSplitOptions.RemoveEmptyEntries);

            //dataGridView1.CurrentCell = null;

            //for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            //{
            //    foreach (string value in values)
            //    {
            //        var row = dataGridView1.Rows[i];
            //        row.Visible = false;
            //        if (
            //            row.Cells["Name"].Value.ToString().Contains(value) || value == "")
            //        {
            //            row.Visible = true;

            //        }

            //    }
            //}


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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // Получаем индекс выделенной строки
            int index = dataGridView1.SelectedRows[0].Index;
            // Создаем переменную, чтобы найти по Id в БД запись
            int id = -1;
            // В выделенной строке в dataGridView ищем Id
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            //Если мы не нашли Id в dataGridView
            if (converted == false)
            {
                // Выходим из метода
                return;
            }
            // Иначе инициализируем форму с аптекой и передаем
            // в форму Id аптеки, чтобы потом внутри формы
            // отображить данные аптеки
            Form2 form = new Form2(id,level);
            // Показываем форму
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
                MessageBox.Show("Компонент удален");
                db.SaveChanges();

            }
            else
            { MessageBox.Show("У вас недостаточно прав, данная функция доступна только Администатору", "Уведомление"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}