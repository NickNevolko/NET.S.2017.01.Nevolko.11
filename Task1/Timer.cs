using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// represents event which starts after sleeping
    /// </summary>
    public class Timer
    {
        /// <summary>
        /// event
        /// </summary>
        public event EventHandler<TimerEventArgs> Notification = delegate { };

        private void OnNotificate(TimerEventArgs e)
        {
            EventHandler<TimerEventArgs> temp = Notification;
            temp?.Invoke(this, e);
        }

        /// <summary>
        /// sets the time of sleeping
        /// </summary>
        /// <param name="time">time period of sleeping</param>
        public void Notificate(int time)
        {
            TimerEventArgs timeToNotify = new TimerEventArgs(time);
            Thread.Sleep(time);
            OnNotificate(timeToNotify);
        }
    }

    /// <summary>
    /// gets additional info for subscribers 
    /// </summary>
    public class TimerEventArgs : EventArgs
    {
        /// <summary>
        /// elapsed time for sleep
        /// </summary>
        public int Time { get; set; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="time"></param>
        public TimerEventArgs(int time)
        {
            Time = time;
        }
    }
}
