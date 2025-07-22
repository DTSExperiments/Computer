using System.ComponentModel;

namespace UR_MTrack
{
    /// <summary>
    /// Distinguish how the received data is displayed.
    /// Live: "oszilloscope" mode.
    /// Experiment: setup for experiment - period measurement.
    /// </summary>
    public enum ChartDataMode
    {
        Live,
        Experiment
    }

    public enum DeviceStatus
    {
        [Description("Off")]
        off,
        [Description("On")]
        on,
        [Description("Disconnected")]
        disconnected,
        [Description("Connected")]
        connected
    }

    public enum ExecutionControl
    {
        [Description("Start")]
        start,
        [Description("Stop")]
        stop,
        [Description("Suspend")]
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
        [Description("Single vertical stripe")]
        singlevstripe = 2,
        [Description("Striped Drum (15 Stripes)")]
        stripeddrum = 3,
        [Description("T-Patterns")]
        tpatterns = 4,
        //[Description("Four vertical bars")]
        //fourvbars = 5,
        //[Description("Diagonals")]
        //diag = 6
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

    public enum ExperimentType
    {
        [Description("Flight Simulator")]
        fs,
        [Description("sw")]
        sw,
        [Description("yt")]
        yt,
        [Description("Optomotor R")]
        optomotorR,
        [Description("Optomotor L")]
        optomotorL,
    }

    public enum PeriodContingency
    {
        [Description("1_3_Q")]
        Q_1_3,
        [Description("2_4_Q")]
        Q_2_4
    }



}
