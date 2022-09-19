using System;
namespace PressureMonitoringSystem
{
    public class PressureSensor : Sensor
    {
        //
        // The reading of the pressure value from the sensor is simulated in this implementation.
        // Because the focus of the exercise is on the other class.
        //

        public PressureSensor(int lowLimit, int maxLimit)
        {
            if (lowLimit < 0 || maxLimit < 0)
            {
                throw new ArgumentOutOfRangeException("Pressure limit cannot be lower than 0.");
            }

            LowLimit = lowLimit;
            MaxLimit = maxLimit;
        }


        const double Offset = 16;
        readonly Random _randomPressureSampleSimulator = new Random();

        public override double readSensorValue()
        {
            double pressureTelemetryValue = ReadPressureSample();

            if(pressureTelemetryValue < 0)
            {
                throw new ArgumentOutOfRangeException("Read pressure value is lower then 0. Something went wrong with sensor");
            }

            return Offset + pressureTelemetryValue;
        }

        private double ReadPressureSample()
        {
            // Simulate info read from a real sensor in a real tire
            return 6 * _randomPressureSampleSimulator.NextDouble() * _randomPressureSampleSimulator.NextDouble();
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
