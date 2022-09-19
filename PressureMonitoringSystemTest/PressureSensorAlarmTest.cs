using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PressureMonitoringSystem;
namespace PressureMonitoringSystemTest
{
    [TestClass]
    public class PressureSensorAlarmTest
    {

        /*
         * Check if alarm status is of on default state
         */
        [TestMethod]
        public void Check_Default_Alarm()
        {   
            Alarm alarm = new Alarm();

            Assert.AreEqual(false, alarm.getAlarmStatus());
        }


        /*
         * Check if alarm will turn on if sensor read value lower the minimum value
         */
        [TestMethod]
        public void Check_Low_Pressure_Alert()
        {
            int lowLimit = 2;
            int maxLimit = 4;
            int currentValue = 1;

            SimulateSensor sensor = new SimulateSensor(lowLimit, maxLimit, currentValue);

            Alarm alarm = new Alarm(sensor);

            alarm.Check();

            Assert.AreEqual(true, alarm.AlarmStatus);
            
        }

        /*
         * Check if alarm will turn on if sensor read value greater the maximum value
         */
        [TestMethod]
        public void Check_High_Pressure_Alert()
        {
            int lowLimit = 2;
            int maxLimit = 4;
            int currentValue = 5;

            SimulateSensor sensor = new SimulateSensor(lowLimit, maxLimit, currentValue);

            Alarm alarm = new Alarm(sensor);

            alarm.Check();

            Assert.AreEqual(true, alarm.AlarmStatus);
        }

        /*
         * Check if alarm is turn off is sensor value is between limits
         */
        [TestMethod]
        public void Check_Pressure_Alert()
        {
            int lowLimit = 2;
            int maxLimit = 4;
            int currentValue = 3;

            SimulateSensor sensor = new SimulateSensor(lowLimit, maxLimit, currentValue);

            Alarm alarm = new Alarm(sensor);

            alarm.Check();

            Assert.AreEqual(false, alarm.AlarmStatus);
        }
    }
}
