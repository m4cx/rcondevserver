﻿namespace RConDevServer.Protocol.Dice.Battlefield3
{
    /// <summary>
    /// Enum for the different origins for a rcon packet
    /// </summary>
    public enum PacketOrigin
    {
        /// <summary>
        /// the packet was originated on the server
        /// </summary>
        Server,

        /// <summary>
        /// the packet was originated on the client
        /// </summary>
        Client
    }
}