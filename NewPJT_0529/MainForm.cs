using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMX3ApiCLR;
using static NewPJT_0529.MainForm;



 

namespace NewPJT_0529
{
    public partial class MainForm : Form
    {
        ServoData Servo1 = new ServoData
        {
            nServoMode = 0,
            Velocity = 0,
            Option1 = 0,
            Option2 = 0,
            Option3 = 0,
            Direction = true
        };
        ServoData Servo2 = new ServoData
        {
            nServoMode = 0,
            Velocity = 0,
            Option1 = 0,
            Option2 = 0,
            Option3 = 0,
            Direction = true
        };

        CurPosServo ToMainXY = new CurPosServo();


        public MainForm()
        {
            Gloval.wmxlib = new WMX3Api();
            Gloval.wmxlib_cm = new WMX3ApiCLR.CoreMotion(Gloval.wmxlib);
            //Gloval.wmxlib_io = new Io(Gloval.wmxlib);
            InitializeComponent();
            MonitorThread.StartThread(this);
        }

        // 현재 시간을 표현해주는 타이머

        private void CurTime_Tick(object sender, EventArgs e)
        {
            LBL_CurTime.Text = (DateTime.Now.ToString("hh:mm:ss"));


        }
        // Servo 1의 상태를 Update 해주는 타이머이다.

        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            SetDirectionColor();
            SetServoOnColor();
            AxisCurrentPos();
            ServoLimit();
            //ServoHome(); 불안정해서 보류
            GetCurPos();

        }




        // 통신 시작 버튼
        private void BTN_Comm_Click(object sender, EventArgs e)
        {
            if (!bCommunication)
            {


                nErr = Gloval.wmxlib.CreateDevice("C:\\Program Files\\SoftServo\\WMX3", DeviceType.DeviceTypeNormal);
                if (nErr != ErrorCode.None)
                {
                    strErrorCode = WMX3Api.ErrorToString(nErr);
                    MessageLog(1, $"WMX3 Start Comm Fail = {strErrorCode}");

                    return;
                }
                nErr = Gloval.wmxlib.StartCommunication(5000);
                if (nErr != ErrorCode.None)
                {
                    strErrorCode = WMX3Api.ErrorToString(nErr);
                    MessageLog(2, $"Fail to Start Communication = {strErrorCode}");
                    return;
                }
                bCommunication = true;
                if (cmAxis1.ServoOn == true)
                {

                }
            }
            else
            {
                nErr = Gloval.wmxlib.StopCommunication(5000);
                if (nErr != ErrorCode.None)
                {
                    strErrorCode = WMX3Api.ErrorToString(nErr);
                    MessageLog(3, $"Failed to Stop Communucation = {strErrorCode}");
                    return;
                }
                nErr = Gloval.wmxlib.CloseDevice();
                if (nErr != ErrorCode.None)
                {
                    strErrorCode = WMX3Api.ErrorToString(nErr);
                    MessageLog(4, $"Failed to Close WMX3 = {strErrorCode}");
                    return;
                }
                bCommunication = false;


            }
            SetCommunicationColor();


        }


        private void BTN_Servo1Mode_Click(object sender, EventArgs e)
        {

            Servo1.nServoMode++;
            SetModeChange();
        }

        // Servo1 On
        private void BTN_Servo1On_Click(object sender, EventArgs e)
        {
            if (cmAxis1.ServoOn == false)
            {
                nErr = Gloval.wmxlib_cm.AxisControl.SetServoOn(0, 1);
                if (nErr != ErrorCode.None)
                {
                    string strErrorCode = WMX3Api.ErrorToString(nErr);
                    MessageLog(5, $"Failed to Servo 1 On = {strErrorCode}");
                    return;
                }

            }
            else
            {
                nErr = Gloval.wmxlib_cm.AxisControl.SetServoOn(0, 0);
                if (nErr != ErrorCode.None)
                {
                    string strErrorCode = WMX3Api.ErrorToString(nErr);
                    MessageLog(6, $"Failed to Servo 1 Off = {strErrorCode}");
                    return;
                }

            }


        }
        // Servo1 Forward
        private void BTN_Servo1Forward_Click(object sender, EventArgs e)
        {
            Servo1.Direction = true;
        }
        // Servo1 backward
        private void BTN_Servo1Backward_Click(object sender, EventArgs e)
        {
            Servo1.Direction = false;
        }
        // Servo1 Jog 동작
        private void BTN_Servo1Run_Click(object sender, EventArgs e)
        {
            SetServo1OptionData();
            if (CheckServo1JogSetting())
            {

                if (cmAxis1.OpState == OperationState.Idle)
                {
                    SendServo1Data(Servo1);
                    Servo1Thread.StartServo1Thread(this);
                }
                else
                {
                    MessageLog(10, "Servo1 모터가 이미 동작 중입니다. Idle 상태일 때 시도해 주세요.");
                }

                
            }
            else
            {
                MessageLog(9, "Servo1 설정값을 다시 확인해주세요");

            }

        }
        // Servo1 동작 Stop 
        private void BTN_Servo1Stop_Click(object sender, EventArgs e)
        {
            Gloval.wmxlib_cm.Motion.Stop(0);
            bServo1Stop = true;
        }


        // servo 2 On
        private void BTN_Servo2On_Click(object sender, EventArgs e)
        {
            if (cmAxis2.ServoOn == false)
            {
                nErr = Gloval.wmxlib_cm.AxisControl.SetServoOn(1, 1);
                if (nErr != ErrorCode.None)
                {
                    string strErrorCode = WMX3Api.ErrorToString(nErr);
                    MessageLog(5, $"Failed to Servo 2 On = {strErrorCode}");
                    return;
                }

            }
            else
            {
                nErr = Gloval.wmxlib_cm.AxisControl.SetServoOn(1, 0);
                if (nErr != ErrorCode.None)
                {
                    string strErrorCode = WMX3Api.ErrorToString(nErr);
                    MessageLog(6, $"Failed to Servo 2 Off = {strErrorCode}");
                    return;
                }
            }
        }

        //Servo 2 Mode 설정
        private void BTN_Servo2Mode_Click(object sender, EventArgs e)
        {
            Servo2.nServoMode++;
            SetModeChange();
        }

        // Servo2 Forward
        private void BTN_Servo2Forward_Click(object sender, EventArgs e)
        {
            Servo2.Direction = true;
        }

        // Servo2 Backward
        private void BTN_Servo2Backward_Click(object sender, EventArgs e)
        {
            Servo2.Direction = false;
        }

        // Servo2 Jog 동작
        private void BTN_Servo2Run_Click(object sender, EventArgs e)
        {
            SetServo2OptionData();
            if (CheckServo2JogSetting())
            {

                if (cmAxis2.OpState == OperationState.Idle)
                {
                    SendServo2Data(Servo2);
                    Servo2Thread.StartServo2Thread(this);
                }
                else
                {
                    MessageLog(14, "Servo2 모터가 이미 동작 중입니다. Idle 상태일 때 시도해 주세요.");
                }


            }
            else
            {
                MessageLog(13, "Servo2 설정값을 다시 확인해주세요");

            }
        }

        // Servo2 Jog 동작 Stop
        private void BTN_Servo2Stop_Click(object sender, EventArgs e)
        {
            Gloval.wmxlib_cm.Motion.Stop(1);
            
            bServo2Stop = true;
        }



        //Servo 1 Home 동작
        private void BTN_Servo1Home_Click(object sender, EventArgs e)
        {
            if (cmAxis1.OpState == OperationState.Idle)
            {
                nErr = Gloval.wmxlib_cm.Home.StartHome(0);
                if (nErr != ErrorCode.None)
                {
                    string strErrorCode = WMX3Api.ErrorToString(nErr);
                    MessageLog(21, $"Servo1 Homing을 진행할 수 없습니다. = {strErrorCode}");
                }
            }
            else
            {
                MessageLog(19, $"Servo1 모터가 이미 동작 중입니다. Homing 할 수 없습니다.");
            }
        }

        //Servo 2 Home 동작
        private void BTN_Servo2Home_Click(object sender, EventArgs e)
        {
            if (cmAxis2.OpState == OperationState.Idle)
            {
                nErr = Gloval.wmxlib_cm.Home.StartHome(1);
                if (nErr != ErrorCode.None)
                {
                    string strErrorCode = WMX3Api.ErrorToString(nErr);
                    MessageLog(22, $"Servo2 Homing을 진행할 수 없습니다. = {strErrorCode}");
                }
            }
            else
            {
                MessageLog(20, $"Servo2 모터가 이미 동작 중입니다. Homing 할 수 없습니다.");
            }
        }

















        //ErrorCode로그 값을 넣는 메세지
        private void MessageLog(int nErr, string msg)
        {
            LBox_Log.Items.Insert(0, $"{LBL_CurTime.Text}  ErrorCode {nErr:D3} : {msg}");
            MessageBox.Show(msg);
        }
        private void MessageLog(ServoData servodata)
        {
            string strMode = "";
            string strTemp = "";
            string strDirection = "";

            if (!bServo1Stop)
            {
                if (servodata.Direction)
                { strDirection = "정방향"; }
                else
                {
                    { strDirection = "역방향"; }
                }

                switch (servodata.nServoMode)
                {
                    case 0:
                        strMode = "절대위치";
                        strTemp = "까지";
                        break;
                    case 1:
                        strMode = "상대위치";
                        strTemp = "만큼";
                        break;
                    case 2:
                        strMode = "동작시간";
                        strTemp = "초 동안";

                        servodata.Option1 = (servodata.Option1 + servodata.Option2 + servodata.Option3) / 1000;
                        break;
                }
                LBox_Log.Items.Insert(0, $"{LBL_CurTime.Text}  Servo1 이 {strMode} 모드에서 {servodata.Velocity} 속도로 {servodata.Option1}{strTemp} {strDirection} 이동하였습니다.");
            }
            if (bServo1Stop)
            {
                LBox_Log.Items.Insert(0, $"{LBL_CurTime.Text}  Servo1 이 정지하였습니다.");
                bServo1Stop = false;
            }

        }

        private void BTN_Monitor_Click(object sender, EventArgs e)
        {
            MonitorForm monitorForm = new MonitorForm();
            monitorForm.Show();
        }


        // 꿀팁 감사합니다

        //End
    }
}
