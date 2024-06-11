using System.Threading;
using System.Windows.Forms;
using WMX3ApiCLR;
using static WMX3ApiCLR.Config;

namespace NewPJT_0529
{
    public class Servo1Thread
    {
        public static MainForm.ServoData Servo1Data = new MainForm.ServoData();

        public static void StartServo1Thread(MainForm mainForm)
        {
            //에러를 저장하기 위한 
            int nErrorCode = 0;


            Thread Servo1Thread = new Thread(() =>
            {
                //Gloval.wmxlib_cm.Config.GetLimitParam(0, &homeParam);
                // 축 번호 설정
                Gloval.posCommand.Axis = 0;
                // 축 이동 Type 설정
                Gloval.posCommand.Profile.Type = ProfileType.Trapezoidal;
                Gloval.timedJogCommand.Profile.Type = WMX3ApiCLR.ProfileType.TimeAccTrapezoidal;
                // 축 속도 설정
                Gloval.timedJogCommand.Profile.Velocity = Servo1Data.Velocity;
                Gloval.posCommand.Profile.Velocity = Servo1Data.Velocity;
                if (!Servo1Data.Direction) Gloval.timedJogCommand.Profile.Velocity *= -1;

                // Mode 에 따른 설정값 저장
                switch (Servo1Data.nServoMode)
                {
                    case 0:
                    case 1:
                        Gloval.posCommand.Target = Servo1Data.Option1;
                        if (!Servo1Data.Direction && Servo1Data.nServoMode > 0 ) Gloval.posCommand.Target *= -1;
                        Gloval.posCommand.Profile.Acc = Servo1Data.Option2;
                        Gloval.posCommand.Profile.Dec = Servo1Data.Option3;
                        break;
                    case 2:
                        Gloval.timedJogCommand.RunTimeMilliseconds = Servo1Data.Option1;
                        Gloval.timedJogCommand.Profile.AccTimeMilliseconds = Servo1Data.Option2;
                        Gloval.timedJogCommand.Profile.DecTimeMilliseconds = Servo1Data.Option3;
                        break;
                }



                switch (Servo1Data.nServoMode)
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
                           if (nErrorCode == 0) mainForm.Servo1ThreadEnd(Servo1Data);

                       });
                }
                else
                {
                    mainForm.GetThread1RunError(nErrorCode);
                    if (nErrorCode == 0) mainForm.Servo1ThreadEnd(Servo1Data);

                }
            });
            Servo1Thread.Start();

        }


    }
}