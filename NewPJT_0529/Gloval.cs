using WMX3ApiCLR;

namespace NewPJT_0529
{
    internal class Gloval
    {
        public static WMX3Api wmxlib;
        public static CoreMotion wmxlib_cm;
        public static Io wmxlib_io;

        public static CoreMotionStatus Cm_Status = new CoreMotionStatus();
        public static Motion.PosCommand posCommand = new Motion.PosCommand();
        public static Motion.TimedJogCommand timedJogCommand = new Motion.TimedJogCommand();

        public static Config.LimitParam Servo1LimitParam;
        public static Config.LimitParam Servo2LimitParam;


    }
}