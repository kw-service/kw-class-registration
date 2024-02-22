using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace kw_enrolment_practice
{
    public partial class Form2 : Form
    {
        int sec = 50;
        int getNum = 0;
        int numOfSub = 6;
        bool isStarted = false;
        int selected = -1;
        List<bool> isFull = new List<bool>();
        List<bool> isDone = new List<bool>();
        List<int> subType = new List<int>();
        public Form2(int subNum)
        {
            InitializeComponent();
            numOfSub = subNum;
        }

        void clearRef()
        {
            codeRef.Text =
            subRef.Text =
            pointRef.Text =
            profRef.Text =
            dayRef.Text =
            timeRef.Text =
            profRef.Text =
            roomRef.Text =
            cntRef.Text =
            typeRef.Text =
            "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            favList.Columns["add"].Index) return;

            if (!isStarted)
            {
                MessageBox.Show("수강신청이 시작된 이후에만 조회가 가능합니다.", "수강신청 연습", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Random rand = new Random();
            String[] typeList = new String[6] { "기필", "기선", "교필", "교선", "전필", "전선"};

            Thread.Sleep(rand.Next(300,500));
            selected = e.RowIndex;
            codeRef.Text = favList.Rows[e.RowIndex].Cells["code"].Value as String;
            subRef.Text = favList.Rows[e.RowIndex].Cells["sub"].Value as String; 
            pointRef.Text = favList.Rows[e.RowIndex].Cells["point"].Value as String; 
            profRef.Text = favList.Rows[e.RowIndex].Cells["prof"].Value as String; 
            String day = favList.Rows[e.RowIndex].Cells["time"].Value as String; day = day.Substring(0, 1);
            String time = favList.Rows[e.RowIndex].Cells["time"].Value as String; time = time.Substring(2, 1);
            dayRef.Text = day;
            timeRef.Text = time;
            typeRef.Text = typeList[subType[e.RowIndex]];
            cntRef.Text = isFull[e.RowIndex] ? "만석" : "여석";
            roomRef.Text = "새404";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String[] dayList = new String[7]{ "월","화","수","목","금","토","일"};
            Random rand = new Random();
            for(int i = 1; i <= numOfSub; i++)
            {
                String no = i.ToString();
                String code = rand.Next(1000, 10000).ToString() + "-" + rand.Next(0, 10).ToString() + "-" + rand.Next(1000, 10000).ToString() + "-" + rand.Next(10, 100).ToString();
                String sub = "과목" + no;
                String point = rand.Next(1, 4).ToString();
                String prof = "교수님" + no;
                String time = dayList[rand.Next(0, 7)] + "(" + rand.Next(1, 9).ToString() + ")";
                favList.Rows.Add("조회", no, code, sub, point, prof, time);

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("수강신청 연습 프로그램을 종료하시겠습니까?", "수강신청 연습", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();      
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            startBtn.Visible = false;
            MessageBox.Show("10초 후 수강신청이 시작됩니다.\n서버 시간을 주목해주세요!", "수강신청 시작", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timer1.Enabled = true;
        }

        void practiceStart()
        {
            Random rand = new Random();
            isStarted = true;
            enrolBtn.Enabled = true;
            enrolBtn.BackColor = Color.Yellow;
            for (int i = 0; i < numOfSub; i++)
            {
                isFull.Add(rand.Next(0, 10) < 2);
                isDone.Add(false);
                subType.Add(rand.Next(0, 6));
            }
                
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 55) curTime.ForeColor = Color.Red;
            else if (sec == 60)
            {
                timer1.Enabled = false;
                curTime.Text = "10:00:00";
                practiceStart();
                MessageBox.Show("수강신청이 시작되었습니다.", "수강신청 시작", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            curTime.Text = "09:59:"+sec.ToString();
        }

        private void enrolBtn_Click(object sender, EventArgs e)
        {
            if (selected==-1)
            {
                MessageBox.Show("수강신청하려는 과목을 먼저 조회해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (isDone[selected])
            {
                MessageBox.Show("이미 수강신청이 완료된 과목입니다!", "수강신청 연습", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (isFull[selected])
            {
                MessageBox.Show("해당 과목은 만석입니다.", "여석 없음", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread.Sleep(new Random().Next(1000, 1500));

            getList.Rows.Add((++getNum).ToString(), codeRef.Text, typeRef.Text, subRef.Text, pointRef.Text, profRef.Text, dayRef.Text, timeRef.Text+"교시", roomRef.Text, "", "", "");
            getList.CurrentCell = null;

            clearRef();
            isDone[selected] = true;
            this.Text = "수강신청 성공 과목 수 [" + getNum.ToString() + "/" + numOfSub.ToString() + "]";
            selected = -1;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yjyoon-dev/kw-enrolment-practice");
        }
    }
}
