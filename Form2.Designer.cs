namespace kw_enrolment_practice
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.favList = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.enrolBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.curTime = new System.Windows.Forms.Label();
            this.codeRef = new System.Windows.Forms.Label();
            this.subRef = new System.Windows.Forms.Label();
            this.typeRef = new System.Windows.Forms.Label();
            this.pointRef = new System.Windows.Forms.Label();
            this.profRef = new System.Windows.Forms.Label();
            this.cntRef = new System.Windows.Forms.Label();
            this.dayRef = new System.Windows.Forms.Label();
            this.timeRef = new System.Windows.Forms.Label();
            this.roomRef = new System.Windows.Forms.Label();
            this.getList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.when2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.favList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getList)).BeginInit();
            this.SuspendLayout();
            // 
            // favList
            // 
            this.favList.AllowUserToAddRows = false;
            this.favList.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.favList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.favList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.favList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.add,
            this.no,
            this.code,
            this.sub,
            this.point,
            this.prof,
            this.time});
            this.favList.Location = new System.Drawing.Point(811, 378);
            this.favList.MultiSelect = false;
            this.favList.Name = "favList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.favList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.favList.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.favList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.favList.RowTemplate.Height = 35;
            this.favList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.favList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.favList.Size = new System.Drawing.Size(593, 320);
            this.favList.TabIndex = 0;
            this.favList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // add
            // 
            this.add.HeaderText = "";
            this.add.Name = "add";
            this.add.Width = 50;
            // 
            // no
            // 
            this.no.HeaderText = "순번";
            this.no.Name = "no";
            this.no.Width = 37;
            // 
            // code
            // 
            this.code.HeaderText = "학정번호";
            this.code.Name = "code";
            this.code.Width = 110;
            // 
            // sub
            // 
            this.sub.HeaderText = "과목명";
            this.sub.Name = "sub";
            this.sub.Width = 200;
            // 
            // point
            // 
            this.point.HeaderText = "학점";
            this.point.Name = "point";
            this.point.Width = 37;
            // 
            // prof
            // 
            this.prof.HeaderText = "담당교수";
            this.prof.Name = "prof";
            this.prof.Width = 80;
            // 
            // time
            // 
            this.time.HeaderText = "강의시간";
            this.time.Name = "time";
            this.time.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "종료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1359, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("굴림", 9F);
            this.button3.Location = new System.Drawing.Point(599, 599);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "수강삭제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // enrolBtn
            // 
            this.enrolBtn.BackColor = System.Drawing.SystemColors.Control;
            this.enrolBtn.Enabled = false;
            this.enrolBtn.Font = new System.Drawing.Font("굴림", 9F);
            this.enrolBtn.Location = new System.Drawing.Point(674, 599);
            this.enrolBtn.Name = "enrolBtn";
            this.enrolBtn.Size = new System.Drawing.Size(125, 36);
            this.enrolBtn.TabIndex = 4;
            this.enrolBtn.Text = "수강신청";
            this.enrolBtn.UseVisualStyleBackColor = false;
            this.enrolBtn.Click += new System.EventHandler(this.enrolBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(859, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "전체검색";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(959, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(123, 20);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "전체검색";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("굴림", 8F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(1120, 21);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(70, 19);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.Text = "전체검색";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Window;
            this.checkBox1.Location = new System.Drawing.Point(1123, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1196, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 47);
            this.button5.TabIndex = 9;
            this.button5.Text = "검색";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1278, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 28);
            this.button6.TabIndex = 10;
            this.button6.Text = "추가";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(859, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 21);
            this.textBox1.TabIndex = 11;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.startBtn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startBtn.Location = new System.Drawing.Point(860, 160);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(494, 104);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "수강신청 연습 시작하기\r\n\r\n(10초 후 서버 오픈과 함께 시작)";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(166, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "10:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // curTime
            // 
            this.curTime.AutoSize = true;
            this.curTime.Font = new System.Drawing.Font("굴림", 9.75F);
            this.curTime.Location = new System.Drawing.Point(166, 621);
            this.curTime.Name = "curTime";
            this.curTime.Size = new System.Drawing.Size(57, 13);
            this.curTime.TabIndex = 14;
            this.curTime.Text = "09:59:50";
            // 
            // codeRef
            // 
            this.codeRef.AutoSize = true;
            this.codeRef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.codeRef.Location = new System.Drawing.Point(275, 364);
            this.codeRef.Name = "codeRef";
            this.codeRef.Size = new System.Drawing.Size(89, 12);
            this.codeRef.TabIndex = 15;
            this.codeRef.Text = "0000-0-0000-00";
            this.codeRef.Visible = false;
            // 
            // subRef
            // 
            this.subRef.AutoSize = true;
            this.subRef.Location = new System.Drawing.Point(429, 363);
            this.subRef.Name = "subRef";
            this.subRef.Size = new System.Drawing.Size(35, 12);
            this.subRef.TabIndex = 16;
            this.subRef.Text = "과목0";
            this.subRef.Visible = false;
            // 
            // typeRef
            // 
            this.typeRef.AutoSize = true;
            this.typeRef.Location = new System.Drawing.Point(547, 388);
            this.typeRef.Name = "typeRef";
            this.typeRef.Size = new System.Drawing.Size(29, 12);
            this.typeRef.TabIndex = 17;
            this.typeRef.Text = "전선";
            this.typeRef.Visible = false;
            // 
            // pointRef
            // 
            this.pointRef.AutoSize = true;
            this.pointRef.Location = new System.Drawing.Point(632, 388);
            this.pointRef.Name = "pointRef";
            this.pointRef.Size = new System.Drawing.Size(11, 12);
            this.pointRef.TabIndex = 18;
            this.pointRef.Text = "3";
            this.pointRef.Visible = false;
            // 
            // profRef
            // 
            this.profRef.AutoSize = true;
            this.profRef.Location = new System.Drawing.Point(743, 387);
            this.profRef.Name = "profRef";
            this.profRef.Size = new System.Drawing.Size(41, 12);
            this.profRef.TabIndex = 19;
            this.profRef.Text = "교수님";
            this.profRef.Visible = false;
            // 
            // cntRef
            // 
            this.cntRef.AutoSize = true;
            this.cntRef.ForeColor = System.Drawing.Color.Red;
            this.cntRef.Location = new System.Drawing.Point(751, 436);
            this.cntRef.Name = "cntRef";
            this.cntRef.Size = new System.Drawing.Size(29, 12);
            this.cntRef.TabIndex = 20;
            this.cntRef.Text = "여석";
            this.cntRef.Visible = false;
            // 
            // dayRef
            // 
            this.dayRef.AutoSize = true;
            this.dayRef.Location = new System.Drawing.Point(281, 413);
            this.dayRef.Name = "dayRef";
            this.dayRef.Size = new System.Drawing.Size(17, 12);
            this.dayRef.TabIndex = 21;
            this.dayRef.Text = "월";
            this.dayRef.Visible = false;
            // 
            // timeRef
            // 
            this.timeRef.AutoSize = true;
            this.timeRef.Location = new System.Drawing.Point(310, 413);
            this.timeRef.Name = "timeRef";
            this.timeRef.Size = new System.Drawing.Size(11, 12);
            this.timeRef.TabIndex = 22;
            this.timeRef.Text = "0";
            this.timeRef.Visible = false;
            // 
            // roomRef
            // 
            this.roomRef.AutoSize = true;
            this.roomRef.Location = new System.Drawing.Point(393, 413);
            this.roomRef.Name = "roomRef";
            this.roomRef.Size = new System.Drawing.Size(35, 12);
            this.roomRef.TabIndex = 23;
            this.roomRef.Text = "새404";
            this.roomRef.Visible = false;
            // 
            // getList
            // 
            this.getList.AllowUserToAddRows = false;
            this.getList.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.getList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.getList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.type,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.day,
            this.when,
            this.room,
            this.day2,
            this.when2,
            this.room2});
            this.getList.Location = new System.Drawing.Point(12, 21);
            this.getList.MultiSelect = false;
            this.getList.Name = "getList";
            this.getList.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.getList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.getList.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.getList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.getList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Cyan;
            this.getList.RowTemplate.Height = 45;
            this.getList.Size = new System.Drawing.Size(794, 315);
            this.getList.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "순번";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 37;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "학정번호";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // type
            // 
            this.type.HeaderText = "구분";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 37;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "과목명";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "학점";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 37;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "담당교수";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // day
            // 
            this.day.HeaderText = "요일1";
            this.day.Name = "day";
            this.day.ReadOnly = true;
            this.day.Width = 77;
            // 
            // when
            // 
            this.when.HeaderText = "시간1";
            this.when.Name = "when";
            this.when.ReadOnly = true;
            this.when.Width = 77;
            // 
            // room
            // 
            this.room.HeaderText = "강의실1";
            this.room.Name = "room";
            this.room.ReadOnly = true;
            this.room.Width = 87;
            // 
            // day2
            // 
            this.day2.HeaderText = "요일2";
            this.day2.Name = "day2";
            this.day2.ReadOnly = true;
            this.day2.Width = 77;
            // 
            // when2
            // 
            this.when2.HeaderText = "시간2";
            this.when2.Name = "when2";
            this.when2.ReadOnly = true;
            this.when2.Width = 77;
            // 
            // room2
            // 
            this.room2.HeaderText = "강의실2";
            this.room2.Name = "room2";
            this.room2.ReadOnly = true;
            this.room2.Width = 87;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1415, 724);
            this.ControlBox = false;
            this.Controls.Add(this.getList);
            this.Controls.Add(this.roomRef);
            this.Controls.Add(this.timeRef);
            this.Controls.Add(this.dayRef);
            this.Controls.Add(this.cntRef);
            this.Controls.Add(this.profRef);
            this.Controls.Add(this.pointRef);
            this.Controls.Add(this.typeRef);
            this.Controls.Add(this.subRef);
            this.Controls.Add(this.codeRef);
            this.Controls.Add(this.curTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.enrolBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.favList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "광운대학교 수강신청 연습 프로그램";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.favList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView favList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn add;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn point;
        private System.Windows.Forms.DataGridViewTextBoxColumn prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button enrolBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label curTime;
        private System.Windows.Forms.Label codeRef;
        private System.Windows.Forms.Label subRef;
        private System.Windows.Forms.Label typeRef;
        private System.Windows.Forms.Label pointRef;
        private System.Windows.Forms.Label profRef;
        private System.Windows.Forms.Label cntRef;
        private System.Windows.Forms.Label dayRef;
        private System.Windows.Forms.Label timeRef;
        private System.Windows.Forms.Label roomRef;
        private System.Windows.Forms.DataGridView getList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn when;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn day2;
        private System.Windows.Forms.DataGridViewTextBoxColumn when2;
        private System.Windows.Forms.DataGridViewTextBoxColumn room2;
    }
}