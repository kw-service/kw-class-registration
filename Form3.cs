using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kw_enrolment_practice
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(trackBar1.Value);
            form2.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            num.Text = trackBar1.Value.ToString() + "개";
        }
    }
}
