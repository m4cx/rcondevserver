﻿namespace RConDevServer.Protocol.Dice.Battlefield3.Tests.Command.Admin
{
    using System.Linq;
    using Battlefield3.Command;
    using Battlefield3.Command.Admin;
    using NUnit.Framework;

    [TestFixture]
    public class MovePlayerCommandTest
    {
        private static MovePlayerCommand CreateCommand()
        {
            var command = new MovePlayerCommand("theplayer", 1, 0, true);
            return command;
        }

        [Test]
        public void Ctor_WithAllProperties_ReturnsInstance()
        {
            var command = CreateCommand();
            Assert.IsNotNull(command);
            Assert.AreEqual(CommandNames.AdminMovePlayer, command.Command);
            Assert.AreEqual("theplayer", command.SoldierName);
            Assert.AreEqual(1, command.TeamId);
            Assert.AreEqual(0, command.SquadId);
            Assert.IsTrue(command.Force);
        }

        [Test]
        public void ToWords_ReturnsWords()
        {
            var command = CreateCommand();
            var expectedWords = new[] {CommandNames.AdminMovePlayer, "theplayer", "1", "0", "true"};
            Assert.IsTrue(expectedWords.SequenceEqual(command.ToWords()));
        }
    }
}