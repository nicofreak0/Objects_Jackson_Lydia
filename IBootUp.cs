﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Jackson_Lydia
{
    internal interface IBootUp
    {

        public bool IsOn { get; set; }

        public void PowerOnOff();

    }
}
