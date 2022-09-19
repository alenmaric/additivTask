using System;
using PressureMonitoringSystem;

namespace PressureMonitoringSystemTest
{
    public class SimulateSensor : Sensor
    {
        private double currentValue = 0;

        public SimulateSensor(int lowLimit, int maxLimit, int currentValue)
        {
            this.LowLimit = lowLimit;
            this.MaxLimit = maxLimit;

            this.currentValue = currentValue;
        }

        public override double readSensorValue()
        {
            return this.currentValue;
        }

        public override double readLowLimit()
        {
            return this.LowLimit;
        }

        public override double readMaxLimit()
        {
            return this.MaxLimit;
        }
    }
}
