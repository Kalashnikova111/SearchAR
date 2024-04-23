using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;//



namespace SearchAR
{
    public partial class Form1 : Form

    {

        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = searchar.mdb";//строка подключен.(исправ)

        private OleDbConnection myConnection;

        //запрос с бд
        public Form1()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);

            myConnection.Open();// исправ(соединен с БД)
        }

        /*SqlCommand cmd;
        SqlCommand read;
        string id;
        bool Mode = true;
        string sql;
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searcharDataSet1.Документы". При необходимости она может быть перемещена или удалена.
            this.документыTableAdapter.Fill(this.searcharDataSet1.Документы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searcharDataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.searcharDataSet1.Сотрудники);

            this.IsMdiContainer = true;//создали подкл. к бд, открыли подкл к бд
            /*if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение к бд");
            }
            */
        }



        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.документыTableAdapter.Fill(this.searcharDataSet1.Документы);
            // Если связывание было выполнено правильно, то должна была появиться эта запись  
            // myBase, tab1 - это название Вашей базы и ее таблицы.
            документыTableAdapter.Update(this.searcharDataSet1.Документы);
            String path = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = searchar.mdb"; // Адрес базы данных
            MessageBox.Show("Новая запись добавлена");
        }

        private void типДокументаDataGridViewTextBoxColumn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form2 Form1 = new Form2();
            Form1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.searcharDataSet1.Сотрудники);
            // Если связывание было выполнено правильно, то должна была появиться эта запись  
            // myBase, tab1 - это название Вашей базы и ее таблицы.
            сотрудникиTableAdapter.Update(this.searcharDataSet1.Сотрудники);
            String path = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = searchar.mdb"; // Адрес базы данных
            MessageBox.Show("Новая запись добавлена");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            документыBindingSource1.RemoveCurrent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            // перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1[i, j].Style.BackColor = Color.White;
                    dataGridView1[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    if (dataGridView1[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        dataGridView1[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridView1[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.searcharDataSet1.Сотрудники);
            // Если связывание было выполнено правильно, то должна была появиться эта запись  
            // myBase, tab1 - это название Вашей базы и ее таблицы.
            сотрудникиTableAdapter.Update(this.searcharDataSet1.Сотрудники);
            String path = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = searchar.mdb"; // Адрес базы данных
            MessageBox.Show("Новая запись добавлена");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            // перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < dataGridView2.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView2.RowCount - 1; j++)
                {
                    dataGridView2[i, j].Style.BackColor = Color.White;
                    dataGridView2[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < dataGridView2.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView2.RowCount - 1; j++)
                {
                    if (dataGridView2[i, j].Value.ToString().IndexOf(textBox2.Text) != -1)
                    {
                        dataGridView2[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridView2[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.searcharDataSet1.Сотрудники);
            // Если связывание было выполнено правильно, то должна была появиться эта запись  
            // myBase, tab1 - это название Вашей базы и ее таблицы.
            сотрудникиTableAdapter.Update(this.searcharDataSet1.Сотрудники);
            String path = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = searchar.mdb"; // Адрес базы данных
            MessageBox.Show("Запись обновлена");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
