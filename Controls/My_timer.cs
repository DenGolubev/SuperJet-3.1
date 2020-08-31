using System;

using System.Windows.Forms;
using System.Drawing;

namespace SuperJet_3._1.Controls
{
    class My_timer: Timer
    {
        static Timer timer1 = new Timer();
        public My_timer()
        {
            timer_process_on();
        }

        private void timer_process_on()
        {
                timer1.Interval = 1000;
                timer1.Enabled = true;
                           
        }
                
    }
}
