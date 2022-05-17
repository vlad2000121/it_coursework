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
    public partial class Form1 : Form
    {
        // Переменная для работы с БД
        private UserContext db;
        // Переменная для того, чтобы запомнить текущий аккаунт
        private User Account;

        public Form1()
        {
            InitializeComponent();
            // Подключаемся к нашей БД
            db = new UserContext();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Login = textBox1.Text;
            user.Password = textBox2.Text;



            // Прогружаем всех пользователей в БД
            db.Users.Load();
            // Для того чтобы запомнить состояние входа
            // если вошли то true, иначе false
            bool isLogin = false;
            // Ищем логин и пароль в БД
            foreach (User usr in db.Users.Where(u => u.Login == user.Login && u.Password == user.Password))
            {
                // Если нашли, то запоминаем, Что нашли
                isLogin = true;
                // И запоминаем пользователя
                Account = usr;
            }
            // Если вы нашли пользователя
            if (isLogin)
            {
                MessageBox.Show("Вы успешно авторизовались", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Если администратор вошел
                if (Account.Level == 1)
                {

                    ////Form2 form2 = new Form2();
                    //SelectionCity selectionCity=new SelectionCity(Account.Level);
                    //// Отображаем форму
                    ////form2.Show();
                    //selectionCity.Show();

                    SelectionStore selectionStore = new SelectionStore("Белгород", Account.Level);
                    selectionStore.Show();
                }
                // Если обычный пользователь вошел
                else if (Account.Level == 3)
                {
                    //SelectionCity selectionCity = new SelectionCity(Account.Level);
                    //// Отображаем форму
                    ////form2.Show();
                    //selectionCity.Show();

                    SelectionStore selectionStore = new SelectionStore("Белгород", Account.Level);
                    selectionStore.Show();
                }
                // Если сотрудник вошел
                else if (Account.Level == 2)
                {
                    //SelectionCity selectionCity = new SelectionCity(Account.Level);
                    //// Отображаем форму
                    ////form2.Show();
                    //selectionCity.Show();

                    SelectionStore selectionStore = new SelectionStore("Белгород", Account.Level);
                    selectionStore.Show();
                }
                // Если не смогли найти пользователя
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                //Form2 form2 = new Form2();
                //form2.Show();



                //db.Users.Add(user);
                //db.SaveChanges();
            }
            // Если не смогли найти пользователя
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Login = textBox1.Text;
            user.Password = textBox2.Text;

            //администратор
            if (radioButton1.Checked == true) user.Level = 1;
            //сотрудник
            if (radioButton2.Checked == true) user.Level = 2;
            //пользователь
            if (radioButton3.Checked == true) user.Level = 3;

            // Переменная для того, чтобы нельзя было иметь в БД 2+ одиновых логинов
            bool isHave = false;
            // Ищем логин
            foreach (User usr in db.Users
                .Where(u => u.Login == user.Login))
            {
                // Если нашли логин, то запоминаем
                isHave = true;
            }
            // Если нашли логин в БД
            if (isHave)
            {
                MessageBox.Show("Такой логин уже есть", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Если не введен логин и пароль
            else if (user.Login == "" && user.Password == "")
            {
                MessageBox.Show("Вы не написали логин и пароль", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Если не введен логин
            else if (user.Login == "")
            {
                MessageBox.Show("Вы не написали логин", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Если не введен пароль
            else if (user.Password == "")
            {
                MessageBox.Show("Вы не написали пароль", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Вы не выбрали привилегии", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Если все хорошо, то добавляем в БД
            else
            {
                // Добавляем в БД
                db.Users.Add(user);
                // Сохраняем изменения в БД
                db.SaveChanges();
                MessageBox.Show("Вы успешно зарегистрировались", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Инициализируем форму администратора
                //Form2 form2 = new Form2();
                //SelectionCity selectionCity = new SelectionCity(user.Level);
                //// Отображаем форму
                ////form2.Show();
                //selectionCity.Show();
                SelectionStore selectionStore = new SelectionStore("Белгород", user.Level);
                selectionStore.Show();
            }





            //Form2 form2 = new Form2();
            //form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение с компьютерными комплектцющими.\n" +
              "Пользователь может добавлять, удалять, изменять обьекты.\n" +
              "Так же предусмотренна возможность поиска обьектов, создание компьютера\n" +

              "Можно создавать заказ на покупку компьютера.\n"+
                  "Создано 3 уровня пользователей: Администратор, Сотрудник, Пользователь.\n"

              , "Информация о программе");
        }
    }
}
