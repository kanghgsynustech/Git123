using System.Threading;
using System.Windows.Forms;
using WMX3ApiCLR;

namespace NewPJT_0529
{
    public class Servo2Thread
    {
        public static MainForm.ServoData Servo2Data = new MainForm.ServoData();

        public static void StartServo2Thread(MainForm mainForm)
        {
            //에러를 저장하기 위한 
            int nErrorCode = 0;


            Thread Servo1Thread = new Thread(() =>
            {
                // 축 번호 설정
                Gloval.posCommand.Axis = 1;
                // 축 이동 Type 설정
                Gloval.posCommand.Profile.Type = ProfileType.Trapezoidal;
                Gloval.timedJogCommand.Profile.Type = WMX3ApiCLR.ProfileType.TimeAccTrapezoidal;
                // 축 속도 설정
                Gloval.timedJogCommand.Profile.Velocity = Servo2Data.Velocity;
                Gloval.posCommand.Profile.Velocity = Servo2Data.Velocity;
                if (!Servo2Data.Direction) Gloval.timedJogCommand.Profile.Velocity *= -1;

                // Mode 에 따른 설정값 저장
                switch (Servo2Data.nServoMode)
                {
                    case 0:
                    case 1:
                        Gloval.posCommand.Target = Servo2Data.Option1;
                        if (!Servo2Data.Direction && Servo2Data.nServoMode > 0) Gloval.posCommand.Target *= -1;
                        Gloval.posCommand.Profile.Acc = Servo2Data.Option2;
                        Gloval.posCommand.Profile.Dec = Servo2Data.Option3;
                        break;
                    case 2:
                        Gloval.timedJogCommand.RunTimeMilliseconds = Servo2Data.Option1;
                        Gloval.timedJogCommand.Profile.AccTimeMilliseconds = Servo2Data.Option2;
                        Gloval.timedJogCommand.Profile.DecTimeMilliseconds = Servo2Data.Option3;
                        break;
                }



                switch (Servo2Data.nServoMode)
                {
                    case 0:
                        nErrorCode = Gloval.wmxlib_cm.Motion.StartPos(Gloval.posCommand);
                        break;
                    case 1:
                        nErrorCode = Gloval.wmxlib_cm.Motion.StartMov(Gloval.posCommand);
                        break;
                    case 2:
                        nErrorCode = Gloval.wmxlib_cm.Motion.StartJog(Gloval.timedJogCommand);
                        break;
                }
                Gloval.wmxlib_cm.Motion.Wait(0);

                if (mainForm.InvokeRequired)
                {
                    mainForm.Invoke((MethodInvoker)delegate
                    {
                        mainForm.GetThread1RunError(nErrorCode);
                        if (nErrorCode == 0) mainForm.Servo1ThreadEnd(Servo2Data);

                    });
                }
                else
                {
                    mainForm.GetThread1RunError(nErrorCode);
                    if (nErrorCode == 0) mainForm.Servo1ThreadEnd(Servo2Data);

                }
            });
            Servo1Thread.Start();

        }


    }
}