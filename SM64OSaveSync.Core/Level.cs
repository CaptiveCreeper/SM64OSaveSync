using System;
using System.Collections.Generic;
using System.Text;

namespace SM64OSaveSync.Core
{
    public class Level
    {
        public bool Star1 { get; set; }
        public bool Star2 { get; set; }
        public bool Star3 { get; set; }
        public bool Star4 { get; set; }
        public bool Star5 { get; set; }
        public bool Star6 { get; set; }
        public bool Star7 { get; set; }

        public bool CanonOpen { get; set; }

        public byte CoinHighScore { get; set; }

    }
}
