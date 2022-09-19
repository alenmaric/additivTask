using System;
namespace PressureMonitoringSystem
{
    public interface ISensor
    {
        public double readSensorValue();

        public double readLowLimit();

        public double readMaxLimit();
    }
}
