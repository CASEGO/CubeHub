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

    public partial class Zayavki : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ARM_Kafe.mdb"; 
        private OleDbConnection myConnection;
        public Zayavki()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Staff f = new Staff();
            f.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRM_KafeDataSet.Заявки_на_работу". При необходимости она может быть перемещена или удалена.
            this.заявки_на_работуTableAdapter.Fill(this.aRM_KafeDataSet.Заявки_на_работу);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            var time = DateTime.Today.ToShortDateString();
            string query = $"INSERT INTO Сотрудники SELECT ФИО, Должность, Дата FROM [Заявки на работу] WHERE Код = {kod}";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            string delete = $"DELETE FROM [Заявки на работу] WHERE Код = {kod}";
            OleDbCommand commandel = new OleDbCommand(delete, myConnection);
            commandel.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            this.заявки_на_работуTableAdapter.Fill(this.aRM_KafeDataSet.Заявки_на_работу);
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Status = textBox1.Text;
            string query = "SELECT [Код], ФИО, Должность, Стаж, Пол, Дата, Телефон FROM [Заявки на работу] WHERE Должность LIKE '%" + Status + "%' ";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
            textBox1.Clear();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            dataGridView1.DataSource = заявкиНаРаботуBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "DELETE FROM [Заявки на работу] WHERE [Код] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            this.заявки_на_работуTableAdapter.Fill(this.aRM_KafeDataSet.Заявки_на_работу);
            textBox2.Clear();
        }
        
   
    }
}
