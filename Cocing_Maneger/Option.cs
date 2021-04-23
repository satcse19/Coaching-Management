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
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

     
    

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Student_Result mm = new Student_Result();
            mm.Show();
        }

        private void Option_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Starting mm = new Starting();
            mm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
