using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_01_AlarmClock___Alisha_C
{

    public delegate void ObserverDelDefault(State state);


    public delegate void ObserverDel(State state, Alarm501 form, AddAndEditAlarm addAndEditAlarmForm, bool isAdd, bool isEdit, DateTime currentTime, bool isOn);


    public delegate void InputHandlerDelForAlarm501(State state);


    public delegate void InputHandlerDelForAddAndEdit(State state);



    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*
            ///model
            Model model = new Model();

            ///
            Controller controller = new Controller();

            //view 1
            Alarm501 alarm = new Alarm501();

            //view 2
            AddAndEditAlarm addAndEditAlarm = new AddAndEditAlarm();
            */

            Application.Run(new Alarm501());
            //addAndEditAlarm.SetInputHandlerForAddAndEdit(controller.handleEvents);
            //controller.SetObserver(model.DisplayState);

            //Application.Run(alarm);
           
        }
    }
}
