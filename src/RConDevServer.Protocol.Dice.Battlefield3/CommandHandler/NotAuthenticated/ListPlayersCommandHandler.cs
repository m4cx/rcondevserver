﻿
namespace RConDevServer.Protocol.Dice.Battlefield3.CommandHandler.NotAuthenticated
{
    /// <summary>
    /// Handles the Command "listPlayers"
    /// </summary>
    public class ListPlayersCommandHandler : ICanHandleClientCommands
    {
        #region ICanHandleClientCommands Members

        public string Command
        {
            get { return RConDevServer.Protocol.Dice.Battlefield3.Constants.COMMAND_LIST_PLAYERS; }
        }

        public bool OnCreatingResponse(PacketSession session, Packet requestPacket, Packet responsePacket)
        {
            // create a default list not regarding the player subset
            foreach (string word in session.Server.PlayerList.ToWords(false))
            {
                responsePacket.Words.Add(word);
            }
            return true;
        }

        #endregion
    }
}