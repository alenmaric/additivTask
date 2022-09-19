using System;
using System.Resources;

namespace PressureMonitoringSystem
{
    public class Alarm: IAlarm
    {

        public bool AlarmStatus { get; private set; } = false;

        readonly ISensor _sensor;

        public Alarm()
        {

        }

        public Alarm(ISensor sensor)
        {
            _sensor = sensor;
        }

        public void Check()
        {
            double psiPressureValue = _sensor.readSensorValue();


            if (psiPressureValue < _sensor.readLowLimit() || _sensor.readMaxLimit() < psiPressureValue)
            {
                AlarmStatus = true;
            }
            else
            {
                AlarmStatus = false;
            }
        }


        public bool getAlarmStatus()
        {
            return AlarmStatus;
        }
        

    }
}
