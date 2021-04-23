using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cocing_Maneger
{
    public partial class SelectPage : Form
    {
        public SelectPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           NewStudent_info mm = new NewStudent_info();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherInfo mm = new TeacherInfo();
            mm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList mm = new StudentList();
            mm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherSalary mm = new TeacherSalary();
            mm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeekSt mm = new WeekSt();
            mm.Show();
        }

        private void SelectPage_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam mm = new Exam();
            mm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Option mm = new Option();
            mm.Show();
        }
    }
}
