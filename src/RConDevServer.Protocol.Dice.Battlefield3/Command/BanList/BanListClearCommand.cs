namespace RConDevServer.Protocol.Dice.Battlefield3.Command.BanList
{
    using System.Collections.Generic;

    /// <summary>
    ///     Clears ban list
    /// </summary>
    public class BanListClearCommand : ICommand
    {
        /// <summary>
        ///     The command name
        /// </summary>
        public string Command
        {
            get { return CommandNames.BanListClear; }
        }

        /// <summary>
        ///     Generates the words needed to create the <see cref="RConDevServer.Protocol.Dice.Common.IPacket" />
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> ToWords()
        {
            return new[] {this.Command};
        }
    }
}