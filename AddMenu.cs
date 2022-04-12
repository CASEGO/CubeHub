using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Новая_курсовая
{
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠛⠉⠉⠉⠉⠉⠉⠙⠛⠻⢿⣿⣿⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⢰⣿⣿⣿⣿⣷⣶⣤⡀⢀⣼⣿⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠙⠛⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠛⠻⢿⣿⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣦⣤⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠙⠻⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⡿⠋⠀⠀⠀⠀⠉⠙⠛⠛⠛⠛⠛⠁⠀⠀⠀⠀⠀⠀⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣷⣦⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣾⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣿⣿⣿⣿⣿⣿
    public partial class AddMenu : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ARM_Kafe.mdb";
        private OleDbConnection myConnection;
        public AddMenu()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Menu f = new Menu();
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string Name = textBox3.Text;
            string Size = textBox2.Text;
            string Price = textBox4.Text;
            string Sostav = textBox5.Text;
            string query = "INSERT INTO Меню ([Код напитка], [Название], [Объем], [Стоимость], [Состав]) VALUES (" + kod + ",'" + Name + "','" + Size + "', '" + Price + "','" + Sostav + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            Hide();
            Menu f = new Menu();
            f.ShowDialog();
            this.Close();

        }
    }
}
