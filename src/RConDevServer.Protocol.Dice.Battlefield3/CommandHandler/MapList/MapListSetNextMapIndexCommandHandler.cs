﻿
namespace RConDevServer.Protocol.Dice.Battlefield3.CommandHandler.MapList
{
    public class MapListSetNextMapIndexCommandHandler : ICanHandleClientCommands
    {
        public string Command
        {
            get { return Constants.COMMAND_MAP_LIST_SET_NEXT_MAP_INDEX; }
        }

        public bool OnCreatingResponse(PacketSession session, Packet requestPacket, Packet responsePacket)
        {
            var mapList = session.Server.MapList;
            if (requestPacket.Words.Count == 2)
            {
                int index = 0;
                if (int.TryParse(requestPacket.Words[1], out index))
                {
                    if (index >= 0 && index < mapList.Count)
                    {
                        // setze den neuen index
                        mapList.NextIndex = index;
                        responsePacket.Words.Add(Constants.RESPONSE_SUCCESS);
                    }
                    else
                    {
                        responsePacket.Words.Add(Constants.RESPONSE_INVALID_MAP_INDEX);
                    }
                }
                else
                {
                    responsePacket.Words.Add(Constants.RESPONSE_INVALID_ARGUMENTS);
                }
            }
            else
            {
                responsePacket.Words.Add(Constants.RESPONSE_INVALID_ARGUMENTS);
            }
            return true;
        }
    }
}