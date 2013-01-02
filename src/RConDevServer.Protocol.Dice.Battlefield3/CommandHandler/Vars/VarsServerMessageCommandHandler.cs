﻿using System;

namespace RConDevServer.Protocol.Dice.Battlefield3.CommandHandler.Vars
{
    public class VarsServerMessageCommandHandler : VarsCommandHandlerBase
    {
        public override string Command
        {
            get { return RConDevServer.Protocol.Dice.Battlefield3.Constants.COMMAND_VARS_SERVER_MESSAGE; }
        }

        protected override bool OnGetValue(PacketSession session, Packet responsePacket)
        {
            responsePacket.Words.Add(RConDevServer.Protocol.Dice.Battlefield3.Constants.RESPONSE_SUCCESS);
            responsePacket.Words.Add(Convert.ToString(session.Server.Vars[Command]));
            return true;
        }

        protected override bool OnSetValue(PacketSession session, Packet requestPacket, Packet responsePacket)
        {
            throw new NotImplementedException();
        }
    }
}