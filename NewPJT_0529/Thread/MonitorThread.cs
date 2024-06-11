using System.Threading;
using System.Windows.Forms;
using WMX3ApiCLR;

namespace NewPJT_0529
{
    public class MonitorThread
    {
        public static void StartThread(MainForm mainForm)
        {
            byte ByInput = 0;
            byte ByOutput = 0;


            Thread thread = new Thread(() =>
            {
                while (!mainForm.IsDisposed)
                {

                    //Gloval.wmxlib_io.GetInByte(0, ref ByInput);
                    //Gloval.wmxlib_io.GetOutByte(0, ref ByOutput);
                    Gloval.wmxlib_cm.GetStatus(ref Gloval.Cm_Status);
                    CoreMotionAxisStatus cmAxis1 = Gloval.Cm_Status.AxesStatus[0];
                    CoreMotionAxisStatus cmAxis2 = Gloval.Cm_Status.AxesStatus[1];
                    cmAxis2.HomeDone = false;

                    if (mainForm.InvokeRequired)
                    {
                        mainForm.Invoke((MethodInvoker)delegate
                        {
                            mainForm.GetIO(ByInput, ByOutput);
                            mainForm.cmAxis1 = cmAxis1;
                            mainForm.cmAxis2 = cmAxis2;
                            mainForm.Servo1Limit(cmAxis1.NegativeLS, cmAxis1.PositiveLS);
                            mainForm.Servo2Limit(cmAxis2.NegativeLS, cmAxis2.PositiveLS);
                        });
                    }
                    else
                    {
                        mainForm.GetIO(ByInput, ByOutput);
                        mainForm.cmAxis1 = cmAxis1;
                        mainForm.cmAxis2 = cmAxis2;
                        mainForm.Servo1Limit(cmAxis1.NegativeLS, cmAxis1.PositiveLS);
                        mainForm.Servo2Limit(cmAxis2.NegativeLS, cmAxis2.PositiveLS);
                    }


                }
            });
            thread.Start();
            mainForm.FormClosing += (sender, e) =>
            {
                thread.Abort();
            };
        }

    }
}