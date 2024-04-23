using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchAR
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void документыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.документыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.searcharDataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "searcharDataSet1.Документы". При необходимости она может быть перемещена или удалена.
            this.документыTableAdapter.Fill(this.searcharDataSet1.Документы);

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

       
    }
}
