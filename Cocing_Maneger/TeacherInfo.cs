using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Cocing_Maneger
{
    public partial class TeacherInfo : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.teacherinfoConnectionString);

        public TeacherInfo()
        {
            InitializeComponent();
        }

        private void TeacherInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Table1 values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"+textBox4.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("New Teacher Added");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            disp_data();

        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Table1 where Id ='" + textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Teacher record Deleted");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectPage mm = new SelectPage();
            mm.Show();
        }
    }
}
