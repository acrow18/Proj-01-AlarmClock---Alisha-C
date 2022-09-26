using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_01_AlarmClock___Alisha_C
{
    /// <summary>
    /// The valid alarm states.
    /// </summary>
    public enum State
    {
        ADD,
        EDIT,
        SET,
        SNOOZE,
        STOP,
    }

    public class Controller
    {
        /// <summary>
        /// Observer delegate for default
        /// </summary>
        public ObserverDelDefault update;

        /// <summary>
        /// Sets observer for default
        /// </summary>
        /// <param name="observerDelDefault">Default observer</param>
        public void SetObserverDefault(ObserverDelDefault observerDelDefault)
        {
            this.update = observerDelDefault;
        }

        /// <summary>
        /// Observer delegate for method with params
        /// </summary>
        public ObserverDel update2;

        /// <summary>
        /// Sets observer delegate for method with params
        /// </summary>
        /// <param name="observerDel">Observer delegate</param>
        public void SetObserver(ObserverDel observerDel) 
        {
            this.update2 = observerDel;
        }


        /// <summary>
        /// Based on the state the controller will act and apply
        /// the logic needed to process the information. After taking action,
        /// it will notify the view of the result.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="args"></param>
        public void handleEvents(State state)
        {
            switch (state)
            {
                case State.ADD:
                    update2(State.ADD, null, null, true, false, DateTime.Now, true);
                    break;
                case State.EDIT:
                    update2(State.EDIT, null, null, false, true, DateTime.Now, true);
                    break;
                case State.SET:
                    update2(State.SET, null, null, false, true, DateTime.Now, true);
                    break;
                case State.SNOOZE:
                    update2(State.SNOOZE, null, null, false, true, DateTime.Now, true);
                    break;
                case State.STOP:
                    update2(State.SNOOZE, null, null, false, true, DateTime.Now, true);
                    break;
                default:
                    break;
            }
        }
    }
}
