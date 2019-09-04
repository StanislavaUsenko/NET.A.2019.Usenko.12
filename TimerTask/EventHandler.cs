using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerTask
{
    public class EventHandler
    {
        public void Message()
        {
            Console.WriteLine("It's event time! " + this.GetType().FullName);
        }
    }
}
