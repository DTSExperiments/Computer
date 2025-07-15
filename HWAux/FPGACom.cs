using System;
using System.Collections.Generic;

namespace UR_MTrack
{
    public static class FPGACom
    {
        public static string GetStartCommand()
        {
            return "S";
        }
        public static string GetStopCommand()
        {
            return "S";
        }

        /// <summary>
        /// returns the command string to either turn the laser on or off
        /// IMPORTANT!!!  Convert the value from NumUpDown with following line.....
        /// Convert.ToByte(Math.Round((double)numericUpDownLaser.Value * 2.55, 0))
        /// </summary>
        /// <param name="pwmValue"></param>
        /// <returns></returns>
        public static byte[] GetLaserCommand(int pwmValue)
        {
            return new byte[1] { (byte)Math.Floor(pwmValue * 2.55) };
        }


        /// <summary>
        /// returns the command string to rotate the scenery
        /// </summary>
        /// <param name="pwmValue"></param>
        /// <returns></returns>
        public static char GetRotateCommand(byte velocity)
        {
            return Convert.ToChar(velocity);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dispat"></param>
        /// <param name="colpat"></param>
        /// <returns></returns>
        public static string GetPatternCommand(DisplayPattern dispat, ColorPattern colpat)
        {
            return string.Format("{0}{1}", (int)dispat, colpat.ToString());
        }
    }
}
