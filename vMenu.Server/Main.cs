﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitizenFX.Core;
using CitizenFX.Core.Native;

using FxEvents;
using FxEvents.Shared.Snowflakes;

using Logger;

namespace vMenu.Server
{
    public class Main : BaseScript
    {
        public static PlayerList PlayerList;

        public Main()
        {
            PlayerList = Players;

            EventDispatcher.Initalize("vMenu:Inbound", "vMenu:Outbound", "vMenu:Signature");

            Debug.WriteLine("vMenu has started.");
        }
    }
}