﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_5._1
{
    internal class Tuesday : Day
    {
        public override void MorningMedication()
        {
            Console.WriteLine("Medicine #2");
        }

        public override void EveningMedication()
        {
            Console.WriteLine("Medicine #4");
            this._context.SwitchTo(new Wednesday());
        }
    }
}
