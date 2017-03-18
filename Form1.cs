using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void файToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автопаркDataSet.Автобус_мәлімет". При необходимости она может быть перемещена или удалена.
            this.автобус_мәліметTableAdapter.Fill(this.автопаркDataSet.Автобус_мәлімет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автопаркDataSet.Автобус". При необходимости она может быть перемещена или удалена.
            this.автобусTableAdapter.Fill(this.автопаркDataSet.Автобус);

        }
    }
}
