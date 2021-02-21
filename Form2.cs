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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add("조회","1", "0000-0-0000-00", "과목1", "3", "교수님", "월(1)");
            dataGridView1.Rows.Add("조회", "2", "0000-0-0000-00", "과목2", "3", "교수님", "화(2)");
            dataGridView1.Rows.Add("조회", "3", "0000-0-0000-00", "과목3", "3", "교수님", "수(3)");
            dataGridView1.Rows.Add("조회", "4", "0000-0-0000-00", "과목4", "3", "교수님", "목(4)");
            dataGridView1.Rows.Add("조회", "5", "0000-0-0000-00", "과목5", "3", "교수님", "금(5)");
            dataGridView1.Rows.Add("조회", "6", "0000-0-0000-00", "과목6", "3", "교수님", "토(6)");
            dataGridView1.Rows.Add("조회", "7", "0000-0-0000-00", "과목7", "3", "교수님", "일(7)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
