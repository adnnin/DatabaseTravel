using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Travel_dot_net_4_7
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            LoadingFIOCombo();
            LoadingTyrCombo();

            dtpFinish.Value = DateTime.Now;
            dtpStart.Value = DateTime.Now;

            dtpFinish.CustomFormat = "dd/MM/yyyy";
            dtpStart.CustomFormat = "dd/MM/yyyy";
            dtpFinish.Format = DateTimePickerFormat.Custom;
            dtpStart.Format = DateTimePickerFormat.Custom;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IDTyrist = (int)ComboFIO.SelectedValue;
            int IDTyr = (int)ComboTyr.SelectedValue;

            try
            {
                
                string Sql = "EXEC zakaz @IDTyr, @IDTyrist, @dtpStart, @dtpFinish, @Strana_tura,@Mesto_projiv,@Org_pit,@Org_eks,@dostavka;";
                //SqlDataAdapter da = new SqlDataAdapter(Sql, Form1.db.GetConnection());
                SqlCommand command = new SqlCommand(Sql, Form1.db.GetConnection());

                command.Parameters.Add("@IDTyr", SqlDbType.Int).Value = IDTyr;
                command.Parameters.Add("@IDTyrist", SqlDbType.Int).Value = IDTyrist;

                command.Parameters.Add("@dtpStart", SqlDbType.Date).Value = dtpStart.Value;
                command.Parameters.Add("@dtpFinish", SqlDbType.Date).Value = dtpFinish.Value;

                command.Parameters.Add("@Strana_tura", SqlDbType.NVarChar).Value = CountryTour.Text;
                command.Parameters.Add("@Mesto_projiv", SqlDbType.NVarChar).Value = MestoProjiv.Text;
                command.Parameters.Add("@Org_pit", SqlDbType.NVarChar).Value = Org_pit.Text;
                command.Parameters.Add("@Org_eks", SqlDbType.NVarChar).Value = Org_eks.Text;
                command.Parameters.Add("@dostavka", SqlDbType.NVarChar).Value = dostavka.Text;


                command.ExecuteNonQuery();
            }
            finally
            {
                MessageBox.Show("Данные внесены!");
            }
            


        }

        void LoadingTyrCombo()
        {
            string Sql = "SELECT id_Тура, CONCAT(Наименование_тура, ' | дата начала: ', Дата_начала) Наименование_тура FROM Туры";

            SqlDataAdapter da = new SqlDataAdapter(Sql, Form1.db.GetConnection());

            DataTable dt = new DataTable();
            da.Fill(dt);
            ComboTyr.DataSource = dt;

            ComboTyr.DisplayMember = "Наименование_тура";
            ComboTyr.ValueMember = "id_Тура";
        }

        void LoadingFIOCombo()
        {
            string Sql = "SELECT ID_туриста, ФИО FROM Туристы";

            SqlDataAdapter da = new SqlDataAdapter(Sql, Form1.db.GetConnection());

            DataTable dt = new DataTable();
            da.Fill(dt);
            ComboFIO.DataSource = dt;

            ComboFIO.DisplayMember = "ФИО";
            ComboFIO.ValueMember = "ID_туриста";
        }
    }
}