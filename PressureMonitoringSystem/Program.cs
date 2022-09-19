using System;

namespace PressureMonitoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            About Task:
                - In this task I did some changes to accept different type of Sensors like temperature sensor.
                  Alarm is used only for check if there is need to change status (On/Off).

                - Also I move minLimit(minimum limit when alarm will turn on) and maxLimit(maximum limit when alarm will turn on) to Sensor.
            */

            PressureSensor sensor = new PressureSensor(17, 21);

            sensor.readSensorValue();

            Alarm alarm = new Alarm(sensor);

            alarm.Check();
 
            bool alartmStatus = alarm.AlarmStatus;

            Console.WriteLine("Alarm status: " + alartmStatus.ToString());
        }
    }
}
