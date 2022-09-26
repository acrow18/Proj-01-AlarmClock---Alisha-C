/*
 * Status.cs
 * Author: Alisha C.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_01_AlarmClock___Alisha_C
{
    public enum Status
    {
        /// <summary>
        /// Alarm is stopped
        /// </summary>
        Stopped,

        /// <summary>
        /// Alarm is snoozed
        /// </summary>
        Snoozed,

        /// <summary>
        /// Alarm is running
        /// </summary>
        Running,

        /// <summary>
        /// Alarm is not running
        /// </summary>
        NotRunning
    }
}
