using System;
using System.Collections.Generic;
using System.Text;

namespace SM64OSaveSync.Core
{
    public class LostCap
    {
        public Int16 X { get; set; }
        public Int16 Y { get; set; }
        public Int16 Z { get; set; }
        public LevelLostIn Map { get; set; }


        public enum LevelLostIn
        {
            NotLost = -1,
            ShiftingSandLand = 0,
            SnowmansLand = 1,
            TallTallMountain = 2
        }

    }
    
}
