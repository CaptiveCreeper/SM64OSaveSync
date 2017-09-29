using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM64OSaveSync.Core;
using SM64OSaveSync.File;
using System.Collections;
using System.IO;

namespace SM64OSaveSync.Console.Test
{
    class Program
    {
        static void Main(string[] args)
        {


            Save test = File.Read.ReadSave(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\SUPER MARIO 64.eep.phazos");
            //Save test = File.Read.ReadSave(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\SUPER MARIO 64_4.eep.lostcap");
            //Save test = File.Read.ReadSave(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\SUPER MARIO 64.eep");

            byte[] save = File.Write.WriteSave(test);
            System.IO.File.WriteAllBytes("SUPER MARIO 64.eep.test", save);
        }
    }
}
