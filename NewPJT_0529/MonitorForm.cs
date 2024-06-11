using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPJT_0529
{
    public partial class MonitorForm : Form
    {
        public static MainForm.CurPosServo MainXY = new MainForm.CurPosServo();

        
             

        bool bRecoding = false;
        public MonitorForm()
        {
            InitializeComponent();
        }
        private void TMR_Draw_Tick(object sender, EventArgs e)
        {
            if (bRecoding)
            {
                Draw(MainXY);
            }
            else
            {
                DrawClear();
                Draw(MainXY);
            }
        }

        private void BTN_Recoding_Click(object sender, EventArgs e)
        {
            bRecoding = true;
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            bRecoding = false;
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 그림

        void Draw(MainForm.CurPosServo MotorXY)
        {
            Graphics grim = panel1.CreateGraphics();

            // 펜을 지정합니다.
            Pen pen1 = new Pen(Color.IndianRed, 2);
  
            // 단색으로 채웁니다.
            SolidBrush brush = new SolidBrush(Color.IndianRed);

            // 단색으로 채워진 원을 그립니다.
            grim.FillEllipse(brush, MainXY.Servo1CurPos, MainXY.Servo2CurPos, 4, 4);


            brush.Dispose();

        }
        void DrawClear()
        {
            panel1.Refresh();
        }
        // 업무의 우선순위를 정하란 말은 무엇을 가장 먼저 버릴지 정하란 말이다.
        // Git 테스트를 위한 주석문 추가
        // Git 테스트를 위한 주석문 추가222
    }
}

