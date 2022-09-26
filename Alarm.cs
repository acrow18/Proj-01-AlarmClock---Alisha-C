/*
 * Alarm.cs
 * Author: Alisha C.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_01_AlarmClock___Alisha_C
{
    /// <summary>
    /// Class for alarm
    /// </summary>
    public class Alarm
    {
        /// <summary>
        /// Update 
        /// </summary>
        public ObserverDel update;

        /// <summary>
        /// Alarm time
        /// </summary>
        public DateTime alarmTime;

        /// <summary>
        /// Current status of the alarm
        /// </summary>
        public Status CurrentStatus;

        /// <summary>
        /// Snooze time
        /// </summary>
        public DateTime snoozeTime;

        /// <summary>
        /// Constructor for new alarm
        /// </summary>
        /// <param name="seconds">Seconds of alarm</param>
        /// <param name="minutes">Minutes of alarm</param>
        /// <param name="hours">Hour of alarm</param>
        /// <param name="isOn">Checks if timer is running</param>
        public Alarm(int hours, int minutes, int seconds, bool isOn)
        {
            alarmTime = DateTime.Now;
            TimeSpan howMuchTime = new TimeSpan(hours, minutes, seconds);
            alarmTime = alarmTime.Date + howMuchTime;

            if (isOn == true)
            {
                CurrentStatus = Status.Running;
            }

            else
            {
                CurrentStatus = Status.Stopped;
            }
        }
        
        /// <summary>
        /// Used to set observer delegate
        /// </summary>
        /// <param name="observerDel">Observer delegate</param>
        public void SetObserver(ObserverDel observerDel) 
        {
            this.update = observerDel;
        }
    }
}
