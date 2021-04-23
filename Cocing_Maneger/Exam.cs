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
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void Exam_Load(object sender, EventArgs e)
        {
       

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
        //ExamresultConnectionString
        SqlConnection con = new SqlConnection(global::Cocing_Maneger.Properties.Settings.Default.ExamresultConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectPage mm = new SelectPage();
            mm.Show();
        }

        
        private void btnadd_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into exam values ('" + nameTextBox.Text + "','" + rollTextBox.Text + "','" + classTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Result Added Successfully");
            
        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from exam";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
          
        }
        private void btndelet_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from exam where Roll='" + rollTextBox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Result Deleted");
           
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
