﻿using System;
using RConDevServer.Protocol.Dice.Battlefield3.Util;

namespace RConDevServer.Protocol.Dice.Battlefield3.CommandHandler.MapList
{
    public class MapListGetRoundsCommandHandler : ICanHandleClientCommands
    {
        #region ICanHandleClientCommands Members

        public string Command
        {
            get { return Constants.COMMAND_MAP_LIST_GET_ROUNDS; }
        }

        public bool OnCreatingResponse(PacketSession session, Packet requestPacket, Packet responsePacket)
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