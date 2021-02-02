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
using MySql.Data.MySqlClient;

namespace Ucak_Bileti_Satan_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        //public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=instagram;Uid=root;Pwd='furkan123';");

     

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    mysqlbaglan.Open();
            //    if (mysqlbaglan.State != ConnectionState.Closed)
            //    {
            //        MessageBox.Show("Bağlantı Başarılı Bir Şekilde Gerçekleşti");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Maalesef Bağlantı Yapılamadı...!");
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            int a, b, v;

        }

        private void button2_Click(object sender, EventArgs e)
        {
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=localhost;Database=instagram;Uid=root;Pwd='furkan123'");
            da = new SqlDataAdapter("Select *From kimlik_bilgileri", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kimlik_bilgileri");
            dataGridView1.DataSource = ds.Tables["kimlik_bilgileri"];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
