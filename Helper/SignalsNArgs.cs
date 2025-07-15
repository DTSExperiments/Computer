using System;
using System.Collections.Generic;

namespace UR_MTrack
{
    internal class Signals
    {
        #region Communication interface

        public static event EventHandler<DeviceStatus> ConnectionStatusChanged;
        public void OnConnectionStatusChanged(object sender, DeviceStatus status)
        {
            ConnectionStatusChanged?.Invoke(sender, status);
        }

        public static event EventHandler<DeviceStatus> DeviceStatusChanged;
        public void OnDeviceStatusChanged(object sender, DeviceStatus status)
        {
            DeviceStatusChanged?.Invoke(sender, status);
        }

        public static event EventHandler<SerialPortSettings> ConnectRequest;
        public void OnConnectRequest(object sender, SerialPortSettings e)
        {
            ConnectRequest?.Invoke(sender, e);
        }

        public static event EventHandler<DataReceivedEventArgs> DataReceived;
        public void OnDataReceived(object sender, DataReceivedEventArgs e)
        {
            DataReceived?.Invoke(sender, e);
        }

        #endregion


        public static event EventHandler<ExecutionControl> AquisitionControl;
        public void OnAquisitionControl(object sender, ExecutionControl e)
        {
            AquisitionControl?.Invoke(sender, e);
        }

        public static event EventHandler<ExecutionControl> ProcessControl;
        public void OnProcessControl(object sender, ExecutionControl e)
        {
            ProcessControl?.Invoke(sender, e);
        }

        public static event EventHandler<IEnumerable<PeriodValues>> PeriodsConfigured;
        public void OnPeriodsConfigured(object sender, IEnumerable<PeriodValues> e)
        {
            PeriodsConfigured?.Invoke(sender, e);
        }

        public static event EventHandler ResetChart;
        public void OnResetChart(object sender, EventArgs e)
        {
            ResetChart?.Invoke(sender, e);
        }

        public static event EventHandler ExperimentConfigChanged;
        public void OnExperimentConfigChanged(object sender, EventArgs e)
        {
            ExperimentConfigChanged?.Invoke(sender, e);
        }

        public static event EventHandler ExperimentFinished;
        public void OnExperimentFinished(object sender, EventArgs e)
        {
            ExperimentFinished?.Invoke(sender, e);
        }
        public static event EventHandler Abort;
        public void OnAbort(object sender, EventArgs e)
        {
            Abort?.Invoke(sender, e);
        }

        public static event EventHandler<PatternEventArgs> SetPattern;
        public void OnSetPattern(object sender, PatternEventArgs e)
        {
            SetPattern?.Invoke(sender, e);
        }

        public static event EventHandler<RotateEventArgs> Rotate;
        public void OnRotate(object sender, RotateEventArgs e)
        {
            Rotate?.Invoke(sender, e);
        }

        public static event EventHandler<int> LaserSwitch;
        public void OnLaserSwitch(object sender, int pwmvalue)
        {
            LaserSwitch?.Invoke(sender, pwmvalue);
        }



        public static event EventHandler<MeasurementEventArgs> MValuesPrepared;
        public void OnMValuesPrepared(object sender, MeasurementEventArgs e)
        {
            MValuesPrepared?.Invoke(sender, e);
        }

        public static event EventHandler<DataHandlerEventArgs> ChartValuesPrepared;
        public void OnChartValuesPrepared(object sender, DataHandlerEventArgs e)
        {
            ChartValuesPrepared?.Invoke(sender, e);
        }
    }



    public class PeriodChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Period value collection.
        /// </summary>
        public PeriodValues Values { get; private set; }
        public PeriodChangedEventArgs(PeriodValues values)
        {
            Values = values;
        }
    }

    public class DataHandlerEventArgs : EventArgs
    {
        /// <summary>
        /// Timestamp. Δt from start of period measurement in seconds. 
        /// </summary>
        public double TimeStamp { get; private set; }
        /// <summary>
        /// Single torque value [raw]
        /// </summary>
        public double Torque { get; private set; }
        /// <summary>
        /// Single location value [raw]
        /// </summary>
        public double Location { get; private set; }


        public DataHandlerEventArgs(double timestamp, double torque, double location)
        {
            TimeStamp = timestamp;
            Torque = torque;
            Location = location;
        }
    }

    public class MeasurementEventArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public MeasurementValues Values { get; private set; }
        public MeasurementEventArgs(MeasurementValues values)
        {
            Values = values;
        }
    }


    public class PatternEventArgs : EventArgs
    {
        public DisplayPattern Pattern { get; private set; }
        /// <summary>
        /// the code used in FPGA-device. [e.g. "G"->green, "D"->cyan,...]
        /// </summary>
        public ColorPattern Color { get; private set; }


        public PatternEventArgs(DisplayPattern p, ColorPattern color)
        {
            Pattern = p;
            Color = color;
        }
    }

    public class RotateEventArgs : EventArgs
    {
        public RotationMode Rotation { get; private set; }
        public int Velocity { get; private set; }

        public RotateEventArgs(RotationMode r, int velocity)
        {
            Rotation = r;
            Velocity = velocity;
        }
    }

    public class DataReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Period value collection.
        /// </summary>       
        public IEnumerable<byte> Bytes { get; private set; }

        public DataReceivedEventArgs(IEnumerable<byte> data)
        {
            Bytes = data;
        }
    }
}
