using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UR_MTrack
{
    public enum ExperimentState
    {
        [Description("Running")]
        start,
        [Description("Stopped")]
        stop,
        [Description("Suspended")]
        suspend,
        [Description("Resume")]
        resume,
        [Description("Laser Trigger")]
        punish
        
    }

    public enum ColorPattern
    {
        //[Description("Red")]
        //R,
        [Description("White")]
        W,
        [Description("Green")]
        G,
        [Description("Blue")]
        B,
        [Description("Cyan")]
        D
        
    }

    public enum DisplayPattern
    {
        [Description("No Pattern")]
        noPattern = 1,
        [Description("One Touch")]
        oneTouch = 2,
        [Description("Multi Touch")]
        multiTouch = 3,
        [Description("T-Pattern")]
        tPattern = 4
    }

    public enum RotationMode
    {
        [Description("Sample")]
        s,
        [Description("Right")]
        r,
        [Description("Left")]
        l
    }

    public enum ArenaType
    {
        [Description("Arena")]
        arena,
        [Description("Light Guide")]
        lightguide,
        [Description("Motor")]
        motor

    }

    public enum DMSType
    {
        [Description("Kopp")]
        kopp,
        [Description("Torquemeter")]
        torquemeter,
        [Description("Goetz")]
        goetz,
        [Description("Shiming")]
        shiming

    }

    public enum PeriodType
    {
        [Description("fs")]
        fs,
        [Description("sw")]
        sw,
        [Description("yt")]
        yt,
        [Description("optomotorR")]
        optomotorR,
        [Description("optomotorL")]
        optomotorL,
    }

    public enum PeriodPattern
    {
        [Description("Single vertical stripe")]
        singlevstripe,
        [Description("Striped Drum (15 Stripes)")]
        stripeddrum,
        [Description("T-Patterns")]
        tpatterns,
        [Description("Four vertical bars")]
        fourvbars,
        [Description("Diagonals")]
        diag
    }

    public enum PeriodContingency
    {
        [Description("1_3_Q")]
        Q_1_3,
        [Description("2_4_Q")]
        Q_2_4
    }



}
