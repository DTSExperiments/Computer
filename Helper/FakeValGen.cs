using System;
using System.Threading;

namespace UR_MTrack.Helper
{
    internal class FakeValGen
    {
        Thread valuegeneratorTh;
        int lastvalue;
        FakeValGen()
        {
            valuegeneratorTh = new Thread(Worker);
            valuegeneratorTh.IsBackground = true;
            valuegeneratorTh.Name = "ThDataHandler";
            valuegeneratorTh.Start();
        }

        void Worker()
        {
            var rnd = new Random();
            while (true)
            {
                rnd.Next(-180, 180);
            }
        }
    }
}
