
namespace Proj_01_AlarmClock___Alisha_C
{
    partial class AddAndEditAlarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxOn = new System.Windows.Forms.CheckBox();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxSet = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxSound = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uxOn
            // 
            this.uxOn.AutoSize = true;
            this.uxOn.Location = new System.Drawing.Point(351, 37);
            this.uxOn.Margin = new System.Windows.Forms.Padding(4);
            this.uxOn.Name = "uxOn";
            this.uxOn.Size = new System.Drawing.Size(49, 21);
            this.uxOn.TabIndex = 0;
            this.uxOn.Text = "On";
            this.uxOn.UseVisualStyleBackColor = true;
            this.uxOn.CheckedChanged += new System.EventHandler(this.uxOn_CheckedChanged);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(56, 94);
            this.uxCancel.Margin = new System.Windows.Forms.Padding(4);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(100, 28);
            this.uxCancel.TabIndex = 2;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxSet
            // 
            this.uxSet.Location = new System.Drawing.Point(300, 94);
            this.uxSet.Margin = new System.Windows.Forms.Padding(4);
            this.uxSet.Name = "uxSet";
            this.uxSet.Size = new System.Drawing.Size(100, 28);
            this.uxSet.TabIndex = 3;
            this.uxSet.Text = "Set";
            this.uxSet.UseVisualStyleBackColor = true;
            this.uxSet.Click += new System.EventHandler(this.uxSet_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(56, 37);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(150, 22);
            this.dateTimePicker.TabIndex = 4;
            // 
            // uxSound
            // 
            this.uxSound.Location = new System.Drawing.Point(234, 35);
            this.uxSound.Name = "uxSound";
            this.uxSound.Size = new System.Drawing.Size(83, 24);
            this.uxSound.TabIndex = 0;
            // 
            // AddAndEditAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 137);
            this.Controls.Add(this.uxSound);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.uxSet);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxOn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAndEditAlarm";
            this.Text = "Add/Edit Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox uxOn;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxSet;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox uxSound;
    }
}