namespace NewPJT_0529
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LBox_Log = new System.Windows.Forms.ListBox();
            this.BTN_Servo1Forward = new System.Windows.Forms.Button();
            this.BTN_Comm = new System.Windows.Forms.Button();
            this.BTN_Emg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_CurTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_Comm = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BTN_Servo1Backward = new System.Windows.Forms.Button();
            this.BTN_Monitor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Servo1Velocity = new System.Windows.Forms.TextBox();
            this.TXT_Servo1Option3 = new System.Windows.Forms.TextBox();
            this.TXT_Servo1Option1 = new System.Windows.Forms.TextBox();
            this.TXT_Servo1Option2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Servo1Stop = new System.Windows.Forms.Button();
            this.BTN_Servo1Run = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Servo1Mode = new System.Windows.Forms.Button();
            this.LBL_Servo1Option3 = new System.Windows.Forms.Label();
            this.LBL_Servo1Option2 = new System.Windows.Forms.Label();
            this.LBL_Servo1Option1 = new System.Windows.Forms.Label();
            this.BTN_Servo1On = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_Servo2Mode = new System.Windows.Forms.Button();
            this.BTN_Servo2Stop = new System.Windows.Forms.Button();
            this.BTN_Servo2Run = new System.Windows.Forms.Button();
            this.BTN_Servo2Backward = new System.Windows.Forms.Button();
            this.TXT_Servo2Option2 = new System.Windows.Forms.TextBox();
            this.TXT_Servo2Option3 = new System.Windows.Forms.TextBox();
            this.LBL_Servo2Option3 = new System.Windows.Forms.Label();
            this.TXT_Servo2Option1 = new System.Windows.Forms.TextBox();
            this.LBL_Servo2Option2 = new System.Windows.Forms.Label();
            this.LBL_Servo2Option1 = new System.Windows.Forms.Label();
            this.BTN_Servo2On = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BTN_Servo2Forward = new System.Windows.Forms.Button();
            this.TXT_Servo2Velocity = new System.Windows.Forms.TextBox();
            this.BTN_Servo1Home = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_Servo2Home = new System.Windows.Forms.Button();
            this.BTN_Servo2POT = new System.Windows.Forms.Button();
            this.BTN_Servo2ORG = new System.Windows.Forms.Button();
            this.BTN_Servo2NOT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_Servo2CurruntPos = new System.Windows.Forms.TextBox();
            this.BTN_Servo1POT = new System.Windows.Forms.Button();
            this.BTN_Servo1ORG = new System.Windows.Forms.Button();
            this.BTN_Servo1NOT = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.TXT_Servo1CurruntPos = new System.Windows.Forms.TextBox();
            this.CurTime = new System.Windows.Forms.Timer(this.components);
            this.ColorTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBox_Log
            // 
            this.LBox_Log.FormattingEnabled = true;
            this.LBox_Log.ItemHeight = 12;
            this.LBox_Log.Location = new System.Drawing.Point(12, 350);
            this.LBox_Log.Name = "LBox_Log";
            this.LBox_Log.Size = new System.Drawing.Size(570, 88);
            this.LBox_Log.TabIndex = 0;
            // 
            // BTN_Servo1Forward
            // 
            this.BTN_Servo1Forward.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Servo1Forward.Location = new System.Drawing.Point(13, 194);
            this.BTN_Servo1Forward.Name = "BTN_Servo1Forward";
            this.BTN_Servo1Forward.Size = new System.Drawing.Size(120, 30);
            this.BTN_Servo1Forward.TabIndex = 1;
            this.BTN_Servo1Forward.Text = "Forward";
            this.BTN_Servo1Forward.UseVisualStyleBackColor = false;
            this.BTN_Servo1Forward.Click += new System.EventHandler(this.BTN_Servo1Forward_Click);
            // 
            // BTN_Comm
            // 
            this.BTN_Comm.BackColor = System.Drawing.Color.DimGray;
            this.BTN_Comm.Location = new System.Drawing.Point(373, 25);
            this.BTN_Comm.Name = "BTN_Comm";
            this.BTN_Comm.Size = new System.Drawing.Size(120, 30);
            this.BTN_Comm.TabIndex = 2;
            this.BTN_Comm.Text = "Communication";
            this.BTN_Comm.UseVisualStyleBackColor = false;
            this.BTN_Comm.Click += new System.EventHandler(this.BTN_Comm_Click);
            // 
            // BTN_Emg
            // 
            this.BTN_Emg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_Emg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Emg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_Emg.Location = new System.Drawing.Point(588, 350);
            this.BTN_Emg.Name = "BTN_Emg";
            this.BTN_Emg.Size = new System.Drawing.Size(200, 88);
            this.BTN_Emg.TabIndex = 3;
            this.BTN_Emg.Text = "Emergency";
            this.BTN_Emg.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "현재 시각";
            // 
            // LBL_CurTime
            // 
            this.LBL_CurTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_CurTime.Location = new System.Drawing.Point(634, 29);
            this.LBL_CurTime.Name = "LBL_CurTime";
            this.LBL_CurTime.Size = new System.Drawing.Size(154, 21);
            this.LBL_CurTime.TabIndex = 5;
            this.LBL_CurTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "통신 상태";
            // 
            // LBL_Comm
            // 
            this.LBL_Comm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Comm.Font = new System.Drawing.Font("굴림", 10F);
            this.LBL_Comm.Location = new System.Drawing.Point(499, 25);
            this.LBL_Comm.Name = "LBL_Comm";
            this.LBL_Comm.Size = new System.Drawing.Size(120, 28);
            this.LBL_Comm.TabIndex = 7;
            this.LBL_Comm.Text = "Stopped";
            this.LBL_Comm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(759, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 70);
            this.button2.TabIndex = 8;
            this.button2.Text = "J\r\nO\r\nG";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(759, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 70);
            this.button3.TabIndex = 9;
            this.button3.Text = "A\r\nU\r\nT\r\nO";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BTN_Servo1Backward
            // 
            this.BTN_Servo1Backward.Location = new System.Drawing.Point(13, 230);
            this.BTN_Servo1Backward.Name = "BTN_Servo1Backward";
            this.BTN_Servo1Backward.Size = new System.Drawing.Size(120, 30);
            this.BTN_Servo1Backward.TabIndex = 10;
            this.BTN_Servo1Backward.Text = "Backward";
            this.BTN_Servo1Backward.UseVisualStyleBackColor = true;
            this.BTN_Servo1Backward.Click += new System.EventHandler(this.BTN_Servo1Backward_Click);
            // 
            // BTN_Monitor
            // 
            this.BTN_Monitor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Monitor.Location = new System.Drawing.Point(759, 218);
            this.BTN_Monitor.Name = "BTN_Monitor";
            this.BTN_Monitor.Size = new System.Drawing.Size(29, 123);
            this.BTN_Monitor.TabIndex = 11;
            this.BTN_Monitor.Text = "M\r\nO\r\nN\r\nI\r\nT\r\nO\r\nR";
            this.BTN_Monitor.UseVisualStyleBackColor = true;
            this.BTN_Monitor.Click += new System.EventHandler(this.BTN_Monitor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "JOG Monitor";
            // 
            // TXT_Servo1Velocity
            // 
            this.TXT_Servo1Velocity.Location = new System.Drawing.Point(139, 23);
            this.TXT_Servo1Velocity.Name = "TXT_Servo1Velocity";
            this.TXT_Servo1Velocity.Size = new System.Drawing.Size(100, 26);
            this.TXT_Servo1Velocity.TabIndex = 13;
            this.TXT_Servo1Velocity.Tag = "0";
            // 
            // TXT_Servo1Option3
            // 
            this.TXT_Servo1Option3.Location = new System.Drawing.Point(139, 113);
            this.TXT_Servo1Option3.Name = "TXT_Servo1Option3";
            this.TXT_Servo1Option3.Size = new System.Drawing.Size(100, 26);
            this.TXT_Servo1Option3.TabIndex = 16;
            // 
            // TXT_Servo1Option1
            // 
            this.TXT_Servo1Option1.Location = new System.Drawing.Point(139, 53);
            this.TXT_Servo1Option1.Name = "TXT_Servo1Option1";
            this.TXT_Servo1Option1.Size = new System.Drawing.Size(100, 26);
            this.TXT_Servo1Option1.TabIndex = 14;
            // 
            // TXT_Servo1Option2
            // 
            this.TXT_Servo1Option2.Location = new System.Drawing.Point(139, 83);
            this.TXT_Servo1Option2.Name = "TXT_Servo1Option2";
            this.TXT_Servo1Option2.Size = new System.Drawing.Size(100, 26);
            this.TXT_Servo1Option2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Velocity";
            // 
            // BTN_Servo1Stop
            // 
            this.BTN_Servo1Stop.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Servo1Stop.Location = new System.Drawing.Point(139, 230);
            this.BTN_Servo1Stop.Name = "BTN_Servo1Stop";
            this.BTN_Servo1Stop.Size = new System.Drawing.Size(100, 30);
            this.BTN_Servo1Stop.TabIndex = 22;
            this.BTN_Servo1Stop.Text = "Stop";
            this.BTN_Servo1Stop.UseVisualStyleBackColor = false;
            this.BTN_Servo1Stop.Click += new System.EventHandler(this.BTN_Servo1Stop_Click);
            // 
            // BTN_Servo1Run
            // 
            this.BTN_Servo1Run.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Servo1Run.Location = new System.Drawing.Point(139, 193);
            this.BTN_Servo1Run.Name = "BTN_Servo1Run";
            this.BTN_Servo1Run.Size = new System.Drawing.Size(100, 30);
            this.BTN_Servo1Run.TabIndex = 21;
            this.BTN_Servo1Run.Text = "Run";
            this.BTN_Servo1Run.UseVisualStyleBackColor = false;
            this.BTN_Servo1Run.Click += new System.EventHandler(this.BTN_Servo1Run_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Servo1Mode);
            this.groupBox1.Controls.Add(this.BTN_Servo1Stop);
            this.groupBox1.Controls.Add(this.BTN_Servo1Run);
            this.groupBox1.Controls.Add(this.BTN_Servo1Backward);
            this.groupBox1.Controls.Add(this.TXT_Servo1Option2);
            this.groupBox1.Controls.Add(this.TXT_Servo1Option3);
            this.groupBox1.Controls.Add(this.LBL_Servo1Option3);
            this.groupBox1.Controls.Add(this.TXT_Servo1Option1);
            this.groupBox1.Controls.Add(this.LBL_Servo1Option2);
            this.groupBox1.Controls.Add(this.LBL_Servo1Option1);
            this.groupBox1.Controls.Add(this.BTN_Servo1On);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BTN_Servo1Forward);
            this.groupBox1.Controls.Add(this.TXT_Servo1Velocity);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F);
            this.groupBox1.Location = new System.Drawing.Point(16, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 277);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motor_1";
            // 
            // BTN_Servo1Mode
            // 
            this.BTN_Servo1Mode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BTN_Servo1Mode.Location = new System.Drawing.Point(13, 158);
            this.BTN_Servo1Mode.Name = "BTN_Servo1Mode";
            this.BTN_Servo1Mode.Size = new System.Drawing.Size(120, 30);
            this.BTN_Servo1Mode.TabIndex = 28;
            this.BTN_Servo1Mode.Text = "Absolute_Pos";
            this.BTN_Servo1Mode.UseVisualStyleBackColor = true;
            this.BTN_Servo1Mode.Click += new System.EventHandler(this.BTN_Servo1Mode_Click);
            // 
            // LBL_Servo1Option3
            // 
            this.LBL_Servo1Option3.AutoSize = true;
            this.LBL_Servo1Option3.Location = new System.Drawing.Point(20, 117);
            this.LBL_Servo1Option3.Name = "LBL_Servo1Option3";
            this.LBL_Servo1Option3.Size = new System.Drawing.Size(35, 16);
            this.LBL_Servo1Option3.TabIndex = 27;
            this.LBL_Servo1Option3.Text = "Dec";
            // 
            // LBL_Servo1Option2
            // 
            this.LBL_Servo1Option2.AutoSize = true;
            this.LBL_Servo1Option2.Location = new System.Drawing.Point(20, 87);
            this.LBL_Servo1Option2.Name = "LBL_Servo1Option2";
            this.LBL_Servo1Option2.Size = new System.Drawing.Size(35, 16);
            this.LBL_Servo1Option2.TabIndex = 26;
            this.LBL_Servo1Option2.Text = "Acc";
            // 
            // LBL_Servo1Option1
            // 
            this.LBL_Servo1Option1.AutoSize = true;
            this.LBL_Servo1Option1.Location = new System.Drawing.Point(20, 57);
            this.LBL_Servo1Option1.Name = "LBL_Servo1Option1";
            this.LBL_Servo1Option1.Size = new System.Drawing.Size(36, 16);
            this.LBL_Servo1Option1.TabIndex = 25;
            this.LBL_Servo1Option1.Text = "Pos";
            // 
            // BTN_Servo1On
            // 
            this.BTN_Servo1On.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Servo1On.Font = new System.Drawing.Font("굴림", 10F);
            this.BTN_Servo1On.Location = new System.Drawing.Point(139, 156);
            this.BTN_Servo1On.Name = "BTN_Servo1On";
            this.BTN_Servo1On.Size = new System.Drawing.Size(100, 30);
            this.BTN_Servo1On.TabIndex = 24;
            this.BTN_Servo1On.Text = "Servo_ON";
            this.BTN_Servo1On.UseVisualStyleBackColor = false;
            this.BTN_Servo1On.Click += new System.EventHandler(this.BTN_Servo1On_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_Servo2Mode);
            this.groupBox2.Controls.Add(this.BTN_Servo2Stop);
            this.groupBox2.Controls.Add(this.BTN_Servo2Run);
            this.groupBox2.Controls.Add(this.BTN_Servo2Backward);
            this.groupBox2.Controls.Add(this.TXT_Servo2Option2);
            this.groupBox2.Controls.Add(this.TXT_Servo2Option3);
            this.groupBox2.Controls.Add(this.LBL_Servo2Option3);
            this.groupBox2.Controls.Add(this.TXT_Servo2Option1);
            this.groupBox2.Controls.Add(this.LBL_Servo2Option2);
            this.groupBox2.Controls.Add(this.LBL_Servo2Option1);
            this.groupBox2.Controls.Add(this.BTN_Servo2On);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.BTN_Servo2Forward);
            this.groupBox2.Controls.Add(this.TXT_Servo2Velocity);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F);
            this.groupBox2.Location = new System.Drawing.Point(286, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 277);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motor_2";
            // 
            // BTN_Servo2Mode
            // 
            this.BTN_Servo2Mode.Font = new System.Drawing.Font("굴림", 9F);
            this.BTN_Servo2Mode.Location = new System.Drawing.Point(13, 156);
            this.BTN_Servo2Mode.Name = "BTN_Servo2Mode";
            this.BTN_Servo2Mode.Size = new System.Drawing.Size(120, 30);
            this.BTN_Servo2Mode.TabIndex = 29;
            this.BTN_Servo2Mode.Text = "Absolute_Pos";
            this.BTN_Servo2Mode.UseVisualStyleBackColor = true;
            this.BTN_Servo2Mode.Click += new System.EventHandler(this.BTN_Servo2Mode_Click);
            // 
            // BTN_Servo2Stop
            // 
            this.BTN_Servo2Stop.Location = new System.Drawing.Point(139, 230);
            this.BTN_Servo2Stop.Name = "BTN_Servo2Stop";
            this.BTN_Servo2Stop.Size = new System.Drawing.Size(100, 30);
            this.BTN_Servo2Stop.TabIndex = 22;
            this.BTN_Servo2Stop.Text = "Stop";
            this.BTN_Servo2Stop.UseVisualStyleBackColor = true;
            this.BTN_Servo2Stop.Click += new System.EventHandler(this.BTN_Servo2Stop_Click);
            // 
            // BTN_Servo2Run
            // 
            this.BTN_Servo2Run.Location = new System.Drawing.Point(139, 193);
            this.BTN_Servo2Run.Name = "BTN_Servo2Run";
            this.BTN_Servo2Run.Size = new System.Drawing.Size(100, 30);
            this.BTN_Servo2Run.TabIndex = 21;
            this.BTN_Servo2Run.Text = "Run";
            this.BTN_Servo2Run.UseVisualStyleBackColor = true;
            this.BTN_Servo2Run.Click += new System.EventHandler(this.BTN_Servo2Run_Click);
            // 
            // BTN_Servo2Backward
            // 
            this.BTN_Servo2Backward.Location = new System.Drawing.Point(13, 230);
            this.BTN_Servo2Backward.Name = "BTN_Servo2Backward";
            this.BTN_Servo2Backward.Size = new System.Drawing.Size(120, 30);
            this.BTN_Servo2Backward.TabIndex = 10;
            this.BTN_Servo2Backward.Text = "Backward";
            this.BTN_Servo2Backward.UseVisualStyleBackColor = true;
            this.BTN_Servo2Backward.Click += new System.EventHandler(this.BTN_Servo2Backward_Click);
            // 
            // TXT_Servo2Option2
            // 
            this.TXT_Servo2Option2.Location = new System.Drawing.Point(139, 83);
            this.TXT_Servo2Option2.Name = "TXT_Servo2Option2";
            this.TXT_Servo2Option2.Size = new System.Drawing.Size(100, 26);
            this.TXT_Servo2Option2.TabIndex = 15;
            // 
            // TXT_Servo2Option3
            // 
            this.TXT_Servo2Option3.Location = new System.Drawing.Point(139, 113);
            this.TXT_Servo2Option3.Name = "TXT_Servo2Option3";
            this.TXT_Servo2Option3.Size = new System.Drawing.Size(100, 26);
            this.TXT_Servo2Option3.TabIndex = 16;
            // 
            // LBL_Servo2Option3
            // 
            this.LBL_Servo2Option3.AutoSize = true;
            this.LBL_Servo2Option3.Location = new System.Drawing.Point(20, 117);
            this.LBL_Servo2Option3.Name = "LBL_Servo2Option3";
            this.LBL_Servo2Option3.Size = new System.Drawing.Size(35, 16);
            this.LBL_Servo2Option3.TabIndex = 27;
            this.LBL_Servo2Option3.Text = "Dec";
            // 
            // TXT_Servo2Option1
            // 
            this.TXT_Servo2Option1.Location = new System.Drawing.Point(139, 53);
            this.TXT_Servo2Option1.Name = "TXT_Servo2Option1";
            this.TXT_Servo2Option1.Size = new System.Drawing.Size(100, 26);
            this.TXT_Servo2Option1.TabIndex = 14;
            // 
            // LBL_Servo2Option2
            // 
            this.LBL_Servo2Option2.AutoSize = true;
            this.LBL_Servo2Option2.Location = new System.Drawing.Point(20, 87);
            this.LBL_Servo2Option2.Name = "LBL_Servo2Option2";
            this.LBL_Servo2Option2.Size = new System.Drawing.Size(35, 16);
            this.LBL_Servo2Option2.TabIndex = 26;
            this.LBL_Servo2Option2.Text = "Acc";
            // 
            // LBL_Servo2Option1
            // 
            this.LBL_Servo2Option1.AutoSize = true;
            this.LBL_Servo2Option1.Location = new System.Drawing.Point(20, 57);
            this.LBL_Servo2Option1.Name = "LBL_Servo2Option1";
            this.LBL_Servo2Option1.Size = new System.Drawing.Size(36, 16);
            this.LBL_Servo2Option1.TabIndex = 25;
            this.LBL_Servo2Option1.Text = "Pos";
            // 
            // BTN_Servo2On
            // 
            this.BTN_Servo2On.Font = new System.Drawing.Font("굴림", 10F);
            this.BTN_Servo2On.Location = new System.Drawing.Point(139, 156);
            this.BTN_Servo2On.Name = "BTN_Servo2On";
            this.BTN_Servo2On.Size = new System.Drawing.Size(100, 30);
            this.BTN_Servo2On.TabIndex = 24;
            this.BTN_Servo2On.Text = "Servo_ON";
            this.BTN_Servo2On.UseVisualStyleBackColor = true;
            this.BTN_Servo2On.Click += new System.EventHandler(this.BTN_Servo2On_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Velocity";
            // 
            // BTN_Servo2Forward
            // 
            this.BTN_Servo2Forward.Location = new System.Drawing.Point(13, 194);
            this.BTN_Servo2Forward.Name = "BTN_Servo2Forward";
            this.BTN_Servo2Forward.Size = new System.Drawing.Size(120, 30);
            this.BTN_Servo2Forward.TabIndex = 1;
            this.BTN_Servo2Forward.Text = "Forward";
            this.BTN_Servo2Forward.UseVisualStyleBackColor = true;
            this.BTN_Servo2Forward.Click += new System.EventHandler(this.BTN_Servo2Forward_Click);
            // 
            // TXT_Servo2Velocity
            // 
            this.TXT_Servo2Velocity.Location = new System.Drawing.Point(139, 23);
            this.TXT_Servo2Velocity.Name = "TXT_Servo2Velocity";
            this.TXT_Servo2Velocity.Size = new System.Drawing.Size(100, 26);
            this.TXT_Servo2Velocity.TabIndex = 13;
            // 
            // BTN_Servo1Home
            // 
            this.BTN_Servo1Home.Font = new System.Drawing.Font("굴림", 10F);
            this.BTN_Servo1Home.Location = new System.Drawing.Point(18, 107);
            this.BTN_Servo1Home.Name = "BTN_Servo1Home";
            this.BTN_Servo1Home.Size = new System.Drawing.Size(171, 30);
            this.BTN_Servo1Home.TabIndex = 28;
            this.BTN_Servo1Home.Text = "Home";
            this.BTN_Servo1Home.UseVisualStyleBackColor = true;
            this.BTN_Servo1Home.Click += new System.EventHandler(this.BTN_Servo1Home_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTN_Servo2Home);
            this.groupBox3.Controls.Add(this.BTN_Servo2POT);
            this.groupBox3.Controls.Add(this.BTN_Servo2ORG);
            this.groupBox3.Controls.Add(this.BTN_Servo2NOT);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TXT_Servo2CurruntPos);
            this.groupBox3.Controls.Add(this.BTN_Servo1Home);
            this.groupBox3.Controls.Add(this.BTN_Servo1POT);
            this.groupBox3.Controls.Add(this.BTN_Servo1ORG);
            this.groupBox3.Controls.Add(this.BTN_Servo1NOT);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.TXT_Servo1CurruntPos);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 12F);
            this.groupBox3.Location = new System.Drawing.Point(546, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 277);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // BTN_Servo2Home
            // 
            this.BTN_Servo2Home.Font = new System.Drawing.Font("굴림", 10F);
            this.BTN_Servo2Home.Location = new System.Drawing.Point(18, 228);
            this.BTN_Servo2Home.Name = "BTN_Servo2Home";
            this.BTN_Servo2Home.Size = new System.Drawing.Size(171, 30);
            this.BTN_Servo2Home.TabIndex = 34;
            this.BTN_Servo2Home.Text = "Home";
            this.BTN_Servo2Home.UseVisualStyleBackColor = true;
            this.BTN_Servo2Home.Click += new System.EventHandler(this.BTN_Servo2Home_Click);
            // 
            // BTN_Servo2POT
            // 
            this.BTN_Servo2POT.Enabled = false;
            this.BTN_Servo2POT.Font = new System.Drawing.Font("굴림", 10F);
            this.BTN_Servo2POT.Location = new System.Drawing.Point(137, 192);
            this.BTN_Servo2POT.Name = "BTN_Servo2POT";
            this.BTN_Servo2POT.Size = new System.Drawing.Size(52, 30);
            this.BTN_Servo2POT.TabIndex = 37;
            this.BTN_Servo2POT.Text = "POT";
            this.BTN_Servo2POT.UseVisualStyleBackColor = true;
            // 
            // BTN_Servo2ORG
            // 
            this.BTN_Servo2ORG.Enabled = false;
            this.BTN_Servo2ORG.Font = new System.Drawing.Font("굴림", 10F);
            this.BTN_Servo2ORG.Location = new System.Drawing.Point(79, 192);
            this.BTN_Servo2ORG.Name = "BTN_Servo2ORG";
            this.BTN_Servo2ORG.Size = new System.Drawing.Size(52, 30);
            this.BTN_Servo2ORG.TabIndex = 36;
            this.BTN_Servo2ORG.Text = "ORG";
            this.BTN_Servo2ORG.UseVisualStyleBackColor = true;
            // 
            // BTN_Servo2NOT
            // 
            this.BTN_Servo2NOT.Enabled = false;
            this.BTN_Servo2NOT.Font = new System.Drawing.Font("굴림", 10F);
            this.BTN_Servo2NOT.Location = new System.Drawing.Point(18, 192);
            this.BTN_Servo2NOT.Name = "BTN_Servo2NOT";
            this.BTN_Servo2NOT.Size = new System.Drawing.Size(55, 30);
            this.BTN_Servo2NOT.TabIndex = 35;
            this.BTN_Servo2NOT.Text = "NOT";
            this.BTN_Servo2NOT.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Motor_2";
            // 
            // TXT_Servo2CurruntPos
            // 
            this.TXT_Servo2CurruntPos.Location = new System.Drawing.Point(99, 154);
            this.TXT_Servo2CurruntPos.Name = "TXT_Servo2CurruntPos";
            this.TXT_Servo2CurruntPos.ReadOnly = true;
            this.TXT_Servo2CurruntPos.Size = new System.Drawing.Size(89, 26);
            this.TXT_Servo2CurruntPos.TabIndex = 32;
            // 
            // BTN_Servo1POT
            // 
            this.BTN_Servo1POT.Enabled = false;
            this.BTN_Servo1POT.Font = new System.Drawing.Font("굴림", 10F);
            this.BTN_Servo1POT.Location = new System.Drawing.Point(137, 71);
            this.BTN_Servo1POT.Name = "BTN_Servo1POT";
            this.BTN_Servo1POT.Size = new System.Drawing.Size(52, 30);
            this.BTN_Servo1POT.TabIndex = 31;
            this.BTN_Servo1POT.Text = "POT";
            this.BTN_Servo1POT.UseVisualStyleBackColor = true;
            // 
            // BTN_Servo1ORG
            // 
            this.BTN_Servo1ORG.Enabled = false;
            this.BTN_Servo1ORG.Font = new System.Drawing.Font("굴림", 10F);
            this.BTN_Servo1ORG.Location = new System.Drawing.Point(79, 71);
            this.BTN_Servo1ORG.Name = "BTN_Servo1ORG";
            this.BTN_Servo1ORG.Size = new System.Drawing.Size(52, 30);
            this.BTN_Servo1ORG.TabIndex = 30;
            this.BTN_Servo1ORG.Text = "ORG";
            this.BTN_Servo1ORG.UseVisualStyleBackColor = true;
            // 
            // BTN_Servo1NOT
            // 
            this.BTN_Servo1NOT.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Servo1NOT.Enabled = false;
            this.BTN_Servo1NOT.Font = new System.Drawing.Font("굴림", 10F);
            this.BTN_Servo1NOT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_Servo1NOT.Location = new System.Drawing.Point(18, 71);
            this.BTN_Servo1NOT.Name = "BTN_Servo1NOT";
            this.BTN_Servo1NOT.Size = new System.Drawing.Size(55, 30);
            this.BTN_Servo1NOT.TabIndex = 29;
            this.BTN_Servo1NOT.Text = "NOT";
            this.BTN_Servo1NOT.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Motor_1";
            // 
            // TXT_Servo1CurruntPos
            // 
            this.TXT_Servo1CurruntPos.Location = new System.Drawing.Point(99, 33);
            this.TXT_Servo1CurruntPos.Name = "TXT_Servo1CurruntPos";
            this.TXT_Servo1CurruntPos.ReadOnly = true;
            this.TXT_Servo1CurruntPos.Size = new System.Drawing.Size(89, 26);
            this.TXT_Servo1CurruntPos.TabIndex = 13;
            // 
            // CurTime
            // 
            this.CurTime.Enabled = true;
            this.CurTime.Tick += new System.EventHandler(this.CurTime_Tick);
            // 
            // ColorTime
            // 
            this.ColorTime.Enabled = true;
            this.ColorTime.Tick += new System.EventHandler(this.ColorTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_Monitor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LBL_Comm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBL_CurTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Emg);
            this.Controls.Add(this.BTN_Comm);
            this.Controls.Add(this.LBox_Log);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBox_Log;
        private System.Windows.Forms.Button BTN_Servo1Forward;
        private System.Windows.Forms.Button BTN_Comm;
        private System.Windows.Forms.Button BTN_Emg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_CurTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_Comm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTN_Servo1Backward;
        private System.Windows.Forms.Button BTN_Monitor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Servo1Velocity;
        private System.Windows.Forms.TextBox TXT_Servo1Option3;
        private System.Windows.Forms.TextBox TXT_Servo1Option1;
        private System.Windows.Forms.TextBox TXT_Servo1Option2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_Servo1Stop;
        private System.Windows.Forms.Button BTN_Servo1Run;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_Servo1Option3;
        private System.Windows.Forms.Label LBL_Servo1Option2;
        private System.Windows.Forms.Label LBL_Servo1Option1;
        private System.Windows.Forms.Button BTN_Servo1On;
        private System.Windows.Forms.Button BTN_Servo1Mode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_Servo2Stop;
        private System.Windows.Forms.Button BTN_Servo2Run;
        private System.Windows.Forms.Button BTN_Servo2Backward;
        private System.Windows.Forms.TextBox TXT_Servo2Option2;
        private System.Windows.Forms.TextBox TXT_Servo2Option3;
        private System.Windows.Forms.Label LBL_Servo2Option3;
        private System.Windows.Forms.TextBox TXT_Servo2Option1;
        private System.Windows.Forms.Label LBL_Servo2Option2;
        private System.Windows.Forms.Label LBL_Servo2Option1;
        private System.Windows.Forms.Button BTN_Servo2On;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BTN_Servo2Forward;
        private System.Windows.Forms.TextBox TXT_Servo2Velocity;
        private System.Windows.Forms.Button BTN_Servo1Home;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTN_Servo1POT;
        private System.Windows.Forms.Button BTN_Servo1ORG;
        private System.Windows.Forms.Button BTN_Servo1NOT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXT_Servo1CurruntPos;
        private System.Windows.Forms.Button BTN_Servo2Mode;
        private System.Windows.Forms.Button BTN_Servo2Home;
        private System.Windows.Forms.Button BTN_Servo2POT;
        private System.Windows.Forms.Button BTN_Servo2ORG;
        private System.Windows.Forms.Button BTN_Servo2NOT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_Servo2CurruntPos;
        private System.Windows.Forms.Timer CurTime;
        private System.Windows.Forms.Timer ColorTime;
    }
}

