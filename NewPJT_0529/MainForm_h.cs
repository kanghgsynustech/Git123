using System.Windows.Forms;
using WMX3ApiCLR;
using static NewPJT_0529.MainForm;

namespace NewPJT_0529
{
    public partial class MainForm : Form
    {

        public int nErr = 0;
        public string strErrorCode = "";
        public bool bCommunication = false;
        public bool bServo1Stop = false;
        public bool bServo2Stop = false;

        // 축의 상태를 받아옴
        public CoreMotionAxisStatus cmAxis1;
        public CoreMotionAxisStatus cmAxis2;




        // Servo Data의 구조체
        public struct ServoData
        {
            public int nServoMode;
            public int Velocity;
            public double Option1;
            public int Option2;
            public int Option3;
            public bool Direction;
        }
        //IO를 가져오기 위한 함수
        public void GetIO(byte Input, byte output)
        {

        }
        // servo1 구조체에 Option 값 투입
        void SetServo1OptionData()
        {
            try
            {
                Servo1.Velocity = int.Parse(TXT_Servo1Velocity.Text);
                Servo1.Option1 = double.Parse(TXT_Servo1Option1.Text);
                Servo1.Option2 = int.Parse(TXT_Servo1Option2.Text);
                Servo1.Option3 = int.Parse(TXT_Servo1Option3.Text);
            }
            catch
            {
                MessageLog(17, "Servo1 동작을 위한 값을 입력해주세요");
            }
        }
        // servo2 구조체에 Option 값 투입
        void SetServo2OptionData()
        {
            try
            {
                Servo2.Velocity = int.Parse(TXT_Servo2Velocity.Text);
                Servo2.Option1 = double.Parse(TXT_Servo2Option1.Text);
                Servo2.Option2 = int.Parse(TXT_Servo2Option2.Text);
                Servo2.Option3 = int.Parse(TXT_Servo2Option3.Text);
            }
            catch
            {
                MessageLog(18, "Servo1 동작을 위한 값을 입력해주세요");
            }

        }
        // Servo 1 Jog 값 Setting 확인
        bool CheckServo1JogSetting()
        {
            bool bCheck = false;
            if (
               Servo1.Velocity > 0 ||
               Servo1.Option1 > 0 ||
               Servo1.Option2 > 0 ||
               Servo1.Option3 > 0
               ) bCheck = true;

            return bCheck;
        }
        // Thread에 Servo1 구조체를 전송
        void SendServo1Data(ServoData servoData)
        {
            Servo1Thread.Servo1Data = servoData;
        }
        // Thread에 Servo1 구조체를 전송
        void SendServo2Data(ServoData servoData)
        {
            Servo2Thread.Servo2Data = servoData;
        }

        //Thread 1의 에러를 가져옴
        public void GetThread1RunError(int nErrorCode)
        {
            if (nErrorCode > 0)
            {
                strErrorCode = WMX3Api.ErrorToString(nErrorCode);
                MessageLog(12, $"Servo 1 구동을 실패하였습니다. : {strErrorCode}");
            }
        }
        // 스레드 1이 종료된 것을 확인
        public void Servo1ThreadEnd(ServoData servoData)
        {
            MessageLog(servoData);
        }


        //Thread 2의 에러를 가져옴
        public void GetThread2RunError(int nErrorCode)
        {
            if (nErrorCode > 0)
            {
                strErrorCode = WMX3Api.ErrorToString(nErrorCode);
                MessageLog(16, $"Servo 2 구동을 실패하였습니다. : {strErrorCode}");
            }
        }
        // 스레드 2이 종료된 것을 확인
        public void Servo2ThreadEnd(ServoData servoData)
        {
            MessageLog(servoData);
        }


        // Servo 2 Jog 값 Setting 확인
        bool CheckServo2JogSetting()
        {
            bool bCheck = false;
            if (
               Servo2.Velocity > 0 ||
               Servo2.Option1 > 0 ||
               Servo2.Option2 > 0 ||
               Servo2.Option3 > 0
               ) bCheck = true;

            return bCheck;
        }

        // Limit Sensor 감시
        public bool Servo1Limit(bool Servo1NOT, bool Servo1POT)
        {
            if (Servo1NOT)
            {
                MessageLog(23, "Servo1 NOT 감지. 센서 상태를 확인하여 주세요");
                Gloval.wmxlib_cm.Motion.Stop(0);
            }

            if (Servo1POT)
            {
                MessageLog(24, "Servo1 POT 감지. 센서 상태를 확인하여 주세요");
                Gloval.wmxlib_cm.Motion.Stop(0);
            }





            return Servo1NOT || Servo1POT;
        }

        public bool Servo2Limit(bool Servo2NOT, bool Servo2POT)
        {

            if (Servo2NOT)
            {
                MessageLog(25, "Servo2 NOT 감지. 센서 상태를 확인하여 주세요");
                Gloval.wmxlib_cm.Motion.Stop(1);
            }

            if (Servo2POT)
            {
                MessageLog(26, "Servo2 POT 감지. 센서 상태를 확인하여 주세요");
                Gloval.wmxlib_cm.Motion.Stop(1);
            }
            return Servo2NOT || Servo2POT;
        }

        // 좌표를 넘기기 위한 현재 Servo 위치값
        public struct CurPosServo
        {
            public int Servo1CurPos;
            public int Servo2CurPos;
        }
        // 모니터 폼으로 보낼 현재 위치 값
        public void GetCurPos()
        {
            ToMainXY.Servo1CurPos = (int)cmAxis1.ActualPos;
            ToMainXY.Servo2CurPos = (int)cmAxis2.ActualPos;
            MonitorForm.MainXY = ToMainXY;
        }
        



    }
}