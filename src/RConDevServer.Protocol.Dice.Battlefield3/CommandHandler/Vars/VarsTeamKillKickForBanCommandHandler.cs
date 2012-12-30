﻿using System;

namespace RConDevServer.Protocol.Dice.Battlefield3.CommandHandler.Vars
{
    public class VarsTeamKillKickForBanCommandHandler : VarsCommandHandlerBase
    {
        public override string Command
        {
            get { return RConDevServer.Protocol.Dice.Battlefield3.Constants.COMMAND_VARS_TEAM_KILL_KICK_FOR_BAN; }
        }

        protected override bool OnGetValue(PacketSession session, Packet responsePacket)
        {
            object value = session.Server.Vars[Command];
            responsePacket.Words.Add(RConDevServer.Protocol.Dice.Battlefield3.Constants.RESPONSE_SUCCESS);
            responsePacket.Words.Add(Convert.ToString(value));
            return true;
        }

        protected override bool OnSetValue(PacketSession session, Packet requestPacket, Packet responsePacket)
        {
            throw new NotImplementedException();
        }
    }
}