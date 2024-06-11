using System;
using System.Drawing;
using System.Windows.Forms;
using WMX3ApiCLR;

namespace NewPJT_0529
{
    public partial class MainForm : Form
    {

        // Servo1 의 Direction의 색상을 바꿔주는 것
        void SetDirectionColor()
        {

            if (cmAxis1.ServoOn)
            {
                if (Servo1.Direction)
                {
                    BTN_Servo1Forward.BackColor = Color.Gold;
                    BTN_Servo1Backward.BackColor = Color.Transparent;
                }
                else
                {
                    BTN_Servo1Forward.BackColor = Color.Transparent;
                    BTN_Servo1Backward.BackColor = Color.Gold;
                }
            }
            else
            {
                BTN_Servo1Forward.BackColor = Color.Transparent;
                BTN_Servo1Backward.BackColor = Color.Transparent;
            }

            if (cmAxis2.ServoOn)
            {
                if (Servo2.Direction)
                {
                    BTN_Servo2Forward.BackColor = Color.Gold;
                    BTN_Servo2Backward.BackColor = Color.Transparent;
                }
                else
                {
                    BTN_Servo2Forward.BackColor = Color.Transparent;
                    BTN_Servo2Backward.BackColor = Color.Gold;
                }
            }
            else
            {
                BTN_Servo2Forward.BackColor = Color.Transparent;
                BTN_Servo2Backward.BackColor = Color.Transparent;
            }


        }
        // Mode의 문자를 바꿔주는 것
        void SetModeChange()
        {
            switch (Servo1.nServoMode)
            {
                case 0:
                    BTN_Servo1Mode.Text = "Absolute_Pos";
                    Set1OptionTextChange("Pos", "Acc", "Dec");
                    break;
                case 1:
                    BTN_Servo1Mode.Text = "Incremental_Pos";
                    Set1OptionTextChange("Value", "Acc", "Dec");
                    break;
                case 2:
                    BTN_Servo1Mode.Text = "Move_by_Time";
                    Set1OptionTextChange("RunTime", "AccTime", "DecTime");
                    break;

                case 3:
                    BTN_Servo1Mode.Text = "Absolute_Pos";
                    Set1OptionTextChange("Pos", "Acc", "Dec");
                    Servo1.nServoMode = 0;
                    break;
            }
            switch (Servo2.nServoMode)
            {
                case 0:
                    BTN_Servo2Mode.Text = "Absolute_Pos";
                    Set2OptionTextChange("Pos", "Acc", "Dec");
                    break;
                case 1:
                    BTN_Servo2Mode.Text = "Incremental_Pos";
                    Set2OptionTextChange("Value", "Acc", "Dec");
                    break;
                case 2:
                    BTN_Servo2Mode.Text = "Move_by_Time";
                    Set2OptionTextChange("RunTime", "AccTime", "DecTime");
                    break;
                case 3:
                    BTN_Servo2Mode.Text = "Absolute_Pos";
                    Set2OptionTextChange("Pos", "Acc", "Dec");
                    Servo2.nServoMode = 0;
                    break;
            }
        }
        // Option LBL의 문자를 변경해준다.
        void Set1OptionTextChange(string option1, string option2, string option3)
        {
            LBL_Servo1Option1.Text = option1;
            LBL_Servo1Option2.Text = option2;
            LBL_Servo1Option3.Text = option3;
        }
        void Set2OptionTextChange(string option1, string option2, string option3)
        {
            LBL_Servo2Option1.Text = option1;
            LBL_Servo2Option2.Text = option2;
            LBL_Servo2Option3.Text = option3;
        }

        // Servo 상태의 색상 및 문자 설정
        void SetServoOnColor()
        {
            if (cmAxis1.ServoOn)
            {
                BTN_Servo1On.Text = "Servo_Off";
                BTN_Servo1On.BackColor = Color.Chartreuse;
            }
            else
            {
                BTN_Servo1On.Text = "Servo_On";
                BTN_Servo1On.BackColor = Color.Transparent;
            }

            if (cmAxis2.ServoOn)
            {
                BTN_Servo2On.Text = "Servo_Off";
                BTN_Servo2On.BackColor = Color.Chartreuse;
            }
            else
            {
                BTN_Servo2On.Text = "Servo_On";
                BTN_Servo2On.BackColor = Color.Transparent;
            }

        }
        // Communication 의 색상 및 문자 설정
        void SetCommunicationColor()
        {
            if (bCommunication)
            {
                BTN_Comm.BackColor = Color.SpringGreen;
                LBL_Comm.Text = "Communicated";
            }
            else
            {
                BTN_Comm.BackColor = Color.DimGray;
                LBL_Comm.Text = "Stopped";
                cmAxis1.ServoOn = false;
                cmAxis2.ServoOn = false;
            }

        }
        // 현재 Servo의 위치를 표현
        void AxisCurrentPos()
        {
            if (cmAxis1.ServoOn)
            {
                TXT_Servo1CurruntPos.Text = cmAxis1.ActualPos.ToString("F3");
            }
            else
            {
                TXT_Servo1CurruntPos.Text = "";
            }
            if (cmAxis2.ServoOn)
            {
                TXT_Servo2CurruntPos.Text = cmAxis2.ActualPos.ToString("F3");
            }
            else
            {
                TXT_Servo2CurruntPos.Text = "";
            }
        }
        //Servo Limit의 상태
        void ServoLimit()
        {
            if (cmAxis1.ServoOn)
            {
                if (cmAxis1.NegativeLS) BTN_Servo1NOT.BackColor = Color.IndianRed;
                else BTN_Servo1NOT.BackColor = Color.Transparent;
                if (cmAxis1.PositiveLS) BTN_Servo1POT.BackColor = Color.IndianRed;
                else BTN_Servo1POT.BackColor = Color.Transparent;
            }

            if (cmAxis2.ServoOn)
            {
                if (cmAxis2.NegativeLS) BTN_Servo2NOT.BackColor = Color.IndianRed;
                else BTN_Servo2NOT.BackColor = Color.Transparent;
                if (cmAxis2.PositiveLS) BTN_Servo2POT.BackColor = Color.IndianRed;
                else BTN_Servo2POT.BackColor = Color.Transparent;
            }
        }
        void ServoHome()
        {
                if (cmAxis1.HomeDone) BTN_Servo1ORG.BackColor = Color.IndianRed;
                else BTN_Servo1ORG.BackColor = Color.Transparent; 

                if (cmAxis2.HomeDone) BTN_Servo2ORG.BackColor = Color.IndianRed;
                else  BTN_Servo2ORG.BackColor = Color.Transparent; cmAxis2.HomeDone = false;
        }

    }
}