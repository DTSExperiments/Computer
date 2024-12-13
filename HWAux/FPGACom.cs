using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UR_MTrack
{
    public class FPGACom
    {
        /// <summary>
        /// returns the command string to either turn the laser on or off
        /// IMPORTANT!!!  Convert the value from NumUpDown with following line.....
        /// Convert.ToByte(Math.Round((double)numericUpDownLaser.Value * 2.55, 0))
        /// </summary>
        /// <param name="pwmValue"></param>
        /// <returns></returns>
        public string GetLaserCommand(int pwmValue)
        {            
            return string.Format("L{0}", pwmValue);
        }

        /// <summary>
        /// returns the command string to rotate the scenery
        /// </summary>
        /// <param name="pwmValue"></param>
        /// <returns></returns>
        public string GetRotateCommand(RotationValue rv, int angle)
        {
            return string.Format("{0}{1}", rv.ToString(), angle);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dispat"></param>
        /// <param name="colpat"></param>
        /// <returns></returns>
        public string GetPatternCommand(DisplayPattern dispat, ColorPattern colpat)
        {
            return string.Format("{0}{1}", (int)dispat, colpat.ToString());
        }

    }
}
