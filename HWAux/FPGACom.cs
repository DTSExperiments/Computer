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
            var dval =Convert.ToChar((int)Math.Round((double)pwmValue * 2.55, 0));
            return string.Format("L{0}", dval);
        }


        /// <summary>
        /// returns the command string to rotate the scenery
        /// </summary>
        /// <param name="pwmValue"></param>
        /// <returns></returns>
        public string GetRotateCommand(RotationMode rv, byte angle)
        {
            return string.Format("{0}{1}", rv.ToString(), (char)angle);
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
