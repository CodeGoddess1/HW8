﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Class;

namespace FleetSim.Objects.InterFace
{
    interface ICar
    {
        int Year { get; set; }
        string Make { get; set; }
        string Model { get; set; }
    }
}
