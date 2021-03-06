﻿namespace RConDevServer.Protocol.Dice.Battlefield3.CommandHandler.MapList
{
    using System;
    using Command;
    using Command.MapList;
    using Common;
    using Util;

    public class MapListGetRoundsCommandHandler : CommandHandlerBase<MapListGetRoundsCommand>
    {
        #region ICanHandleClientCommands Members

        public override string Command
        {
            get { return Constants.COMMAND_MAP_LIST_GET_ROUNDS; }
        }

        public override bool OnCreatingResponse(PacketSession session, MapListGetRoundsCommand command, Packet requestPacket, Packet responsePacket)
        {
            if (requestPacket.Words.Count == 1)
            {
                int currentRound = session.Server.MapList.CurrentRound;
                int totalRounds = session.Server.CurrentMapListItem.Rounds;
                var words = new[]
                    {
                        Constants.RESPONSE_SUCCESS,
                        Convert.ToString(currentRound),
                        Convert.ToString(totalRounds)
                    };
                StringListExtensions.AddRange(responsePacket.Words, words);
            }
            else
            {
                responsePacket.Words.Add(Constants.RESPONSE_INVALID_ARGUMENTS);
            }
            return true;
        }

        #endregion
    }
}