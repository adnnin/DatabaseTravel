using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Travel_dot_net_4_7
{  
    
    public partial class Form1 : Form
    {
        public static Database db = new Database();
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "турфирмаDataSet.Туристы". При необходимости она может быть перемещена или удалена.
            this.туристыTableAdapter.Fill(this.турфирмаDataSet.Туристы);
            db.openConnection();
            //           db.CheckConnection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.туристыTableAdapter.FillBy(this.турфирмаDataSet.Туристы);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
