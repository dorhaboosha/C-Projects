﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class ElectricEngine : Engine
    {
        internal ElectricEngine(float i_MaxEngineAmount)
            : base(i_MaxEngineAmount)
        {
        }
    }
}