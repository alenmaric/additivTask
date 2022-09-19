using System;
namespace PressureMonitoringSystem
{
    public abstract class Sensor: ISensor
    {
        public double LowLimit { get; set; }
        public double MaxLimit { get; set; }

        public abstract double readSensorValue();

        public abstract double readLowLimit();

        public abstract double readMaxLimit();
    }
}
