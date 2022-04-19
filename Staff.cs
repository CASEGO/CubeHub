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

    public partial class Staff : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ARM_Kafe.mdb"; //Создание параметров подключения к базе данных
        private OleDbConnection myConnection;
        public Staff()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Home f = new Home();
            f.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Zayavki f = new Zayavki();
            f.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRM_KafeDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.aRM_KafeDataSet.Сотрудники);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Status = textBox2.Text;
            string query = "SELECT [Код], ФИО, Должность, Зарплата, Дата FROM Сотрудники WHERE Должность LIKE '%" + Status + "%' ";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            dataGridView1.DataSource = сотрудникиBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Сотрудники WHERE [Код] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            this.сотрудникиTableAdapter.Fill(this.aRM_KafeDataSet.Сотрудники);
            textBox2.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox3.Text);
            string query = "UPDATE Сотрудники SET Зарплата ='" + textBox4.Text + "' WHERE [Код] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            this.сотрудникиTableAdapter.Fill(this.aRM_KafeDataSet.Сотрудники);
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
