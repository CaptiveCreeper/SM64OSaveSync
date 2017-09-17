using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM64OSaveSync.Core;
using SM64OSaveSync.File;

namespace SM64OSaveSync.Console.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Save test = File.Read.ReadSave(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\SUPER MARIO 64.eep.phazos");
            //Save test = File.Read.ReadSave(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\SUPER MARIO 64.eep");
        }
    }
}
