﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using static BP_Essentials.EssentialsVariablesPlugin;
using static BP_Essentials.EssentialsMethodsPlugin;

namespace BP_Essentials.Commands
{
    class Reload : EssentialsChatPlugin
    {
        public static void Run(SvPlayer player)
        {
            var shPlayer = GetShBySv.Run(player);
            if (shPlayer != null)
            {
                if (shPlayer.admin)
                    BP_Essentials.Reload.Run(false, player);
                else
                    player.SendToSelf(Channel.Unsequenced, ClPacket.GameMessage, MsgNoPerm);
            }
        }
    }
}
