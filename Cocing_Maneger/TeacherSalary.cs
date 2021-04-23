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
    public partial class TeacherSalary : Form
    {
        public TeacherSalary()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\teachersalary.mdf;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void TeacherSalary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teachersalaryDataSet1.Table4' table. You can move, or remove it, as needed.
           // this.table4TableAdapter.Fill(this.teachersalaryDataSet1.Table4);
            // TODO: This line of code loads data into the 'teachersalaryDataSet.Table4' table. You can move, or remove it, as needed.
            this.table4TableAdapter.Fill(this.teachersalaryDataSet.Table4);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
     
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Table4 values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Sallery Added");

        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table4";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btmshow_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            labtotal.Text = sum.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectPage mm = new SelectPage();
            mm.Show();
        }
    }
}
