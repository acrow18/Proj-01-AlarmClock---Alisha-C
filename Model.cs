using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_01_AlarmClock___Alisha_C
{
    class Model
    {
        public void DisplayState(State state, Alarm501 form, AddAndEditAlarm addAndEditAlarmForm, bool isAdd, bool isEdit, DateTime currentTime, bool isOn) 
        {
            switch (state) 
            {
                case State.ADD:
                    var AddAlarm = new AddAndEditAlarm(form);
                    AddAlarm.Show();
                    break;
                case State.EDIT:
                    var EditAlarm = new AddAndEditAlarm(form, isEdit);
                    EditAlarm.Show();
                    break;
                /*
                case State.SET:
                    //setting a new Alarm
                    if (isAdd == true)
                    {
                        this.addAndEditAlarmForm.AddAlarm(currentTime, isOn);
                        this.Close();
                    }
                    else
                    {
                        this.addAndEditAlarmForm.EditAlarm(currentTime, isOn);
                        this.Close();
                    }
                    break;
                */
            }
        }
    }
}
