using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Jackson_Lydia
{
    internal interface IBootUp
    {
        // shows if the computer is on or off
        public bool IsOn { get; set; }

        // method to make it on or off
        public void PowerOnOff();

    }
}
