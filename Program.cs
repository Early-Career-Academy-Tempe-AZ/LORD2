﻿using RandM.RMLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LORD2
{
    class Program
    {
        static void Main(string[] args)
        {
            Door.Startup(args);

            // If new player, call newplayer in gametxt.ref
            // If player exists, call startgame in gametxt.ref
            RTReader.RunSection("GAMETXT.REF", "NEWPLAYER");
            
            if (Debugger.IsAttached)
            {
                Crt.FastWrite(StringUtils.PadRight("Terminating...hit a key to quit", '\0', 80), 1, 25, 31);
                Crt.ReadKey();
            }
            
            Door.Shutdown();
        }
    }
}
