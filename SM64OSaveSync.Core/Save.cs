using System;
using System.Collections.Generic;
using System.Text;

namespace SM64OSaveSync.Core
{
    public class Save
    {
        public Mario A { get; set; }
        public Mario A_Backup { get; set; }

        public Mario B { get; set; }
        public Mario B_Backup { get; set; }

        public Mario C { get; set; }
        public Mario C_Backup { get; set; }

        public Mario D { get; set; }
        public Mario D_Backup { get; set; }

        public GlobalConfig Config { get; set; }
        public GlobalConfig ConfigBackup { get; set; }

        public Save()
        {
            A = new Mario();
            A_Backup = new Mario();
            B = new Mario();
            B_Backup = new Mario();
            C = new Mario();
            C_Backup = new Mario();
            D = new Mario();
            D_Backup = new Mario();

        }
    }
}
