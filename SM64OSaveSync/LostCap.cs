using System;
using System.Collections.Generic;
using System.Text;

namespace SM64OSaveSync.Core
{
    class LostCap
    {
        Int16 X { get; set; }
        Int16 Y { get; set; }
        Int16 Z { get; set; }
        LevelLostIn Map { get; set; }


        private enum LevelLostIn
        {
            ShiftingSandLand = 0,
            SnowmansLand = 1,
            TallTallMountain = 2
        }

    }
    
}
