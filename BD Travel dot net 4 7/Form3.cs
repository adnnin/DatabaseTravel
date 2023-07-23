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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadingFIOCombo();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string Sql = "EXEC tourist @id_turist, @FIO, @Passdata;";
                //, @Kids
                SqlCommand command = new SqlCommand(Sql, Form1.db.GetConnection());

                command.Parameters.Add("@id_turist", SqlDbType.Int).Value=Int32.Parse(Id.Text);
                command.Parameters.Add("@FIO", SqlDbType.NVarChar).Value = FIO.Text;
                command.Parameters.Add("@Passdata", SqlDbType.NVarChar).Value = Passpdata.Text;
                //if (Kids.Checked)
                //{
                //    command.Parameters.Add("@Kids", SqlDbType.Binary).Value = Int32.ToString(1);
                //}
                //else
                //{
                //    command.Parameters.Add("@Kids", SqlDbType.Binary).Value = ToString(0);
                //}


                command.ExecuteNonQuery();
            }
            finally
            {
                MessageBox.Show("Данные внесены!");
            }
        }
        void LoadingFIOCombo()
        {
            string Sql = "SELECT ID_туриста, ФИО FROM Туристы";

            SqlDataAdapter da = new SqlDataAdapter(Sql, Form1.db.GetConnection());

            DataTable dt = new DataTable();
            da.Fill(dt);
         
        }
    }
}
