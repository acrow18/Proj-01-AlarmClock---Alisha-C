/*
 * AddAndEditAlarm.cs
 * Author: Alisha C.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_01_AlarmClock___Alisha_C
{
    public partial class AddAndEditAlarm : Form
    {
        /// <summary>
        /// Handler
        /// </summary>
        public InputHandlerDelForAddAndEdit addAndEditHan;

        /// <summary>
        /// Creates a new Add and Edit form
        /// </summary>
        public Alarm501 addAndEditAlarmForm;


        /// <summary>
        /// Current Status of alarm
        /// </summary>
        public Status currentStatus;

        /// <summary>
        /// Checking if an alarm is being added
        /// </summary>
        public bool isAdd;


        /// <summary>
        /// 
        /// </summary>
        public void uxSoundComboBoxBind() 
        {
            List<AlarmSound> soundList = Enum.GetValues(typeof(AlarmSound)).OfType<AlarmSound>().ToList();
            uxSound.DataSource = soundList;
        }

        //different constructors for different cases

        public AddAndEditAlarm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Used to add
        /// </summary>
        /// <param name="Form"></param>
        public AddAndEditAlarm(Alarm501 form) 
        {
            addAndEditAlarmForm = form;
            isAdd = true;
            InitializeComponent();
        }

        /// <summary>
        /// Used to edit
        /// </summary>
        /// <param name="Form">Alarmlist</param>
        /// <param name="isEdit">checks if is edit</param>
        public AddAndEditAlarm(Alarm501 form, bool isEdit)
        {
            addAndEditAlarmForm = form;
            isAdd = false;
            InitializeComponent();
        }


        /// <summary>
        /// Links AddAndEdit to Alarm
        /// </summary>
        /// <param name="handler">Handler</param>
        public void SetInputHandlerForAddAndEdit(InputHandlerDelForAddAndEdit handler) 
        {
            this.addAndEditHan = handler;
        }
      
        /// <summary>
        /// Sets current alarm
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void uxSet_Click(object sender, EventArgs e)
        {

            //gets current time
            DateTime currentTime = dateTimePicker.Value;

            //setting a new Alarm
            if (isAdd == true)
            {
                this.addAndEditAlarmForm.AddAlarm(currentTime, uxOn.Checked);
                this.Close();
            }


            else 
            {
                this.addAndEditAlarmForm.EditAlarm(currentTime, uxOn.Checked);
                this.Close();
            }
        }

        /// <summary>
        /// Used to changed if the On button is checked
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void uxOn_CheckedChanged(object sender, EventArgs e)
        {
            
            if (uxOn.Checked == true)
            {
                currentStatus = Status.Running;
            }

            else 
            {
                currentStatus = Status.NotRunning;
            }
            
        }


        /// <summary>
        /// Cancels the current alarm
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
