using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerTask
{
    public class UserTimer
    {
        public delegate void MethodContainer();

        public UserTimer(int seconds)
        {
            this._seconds = seconds;
        }
        private int _seconds { get; set; }
        public void Timer ()
        {
            var timer = new Timer();


        }

        private void DecrementSecond(object obj) { _seconds--; }
    }
}
