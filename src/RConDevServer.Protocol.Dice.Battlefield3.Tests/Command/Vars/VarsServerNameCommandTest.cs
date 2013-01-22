﻿namespace RConDevServer.Protocol.Dice.Battlefield3.Tests.Command.Vars
{
    using Battlefield3.Command;
    using Battlefield3.Command.Vars;
    using NUnit.Framework;

    [TestFixture]
    public class VarsServerNameCommandTest : VarsTestBase<VarsServerNameCommand, string>
    {
        public override string CommandName
        {
            get { return CommandNames.VarsServerName; }
        }

        public override VarsServerNameCommand CreateCommandWithValue()
        {
            return new VarsServerNameCommand(this.GetValue());
        }

        public override VarsServerNameCommand CreateCommandWithoutValue()
        {
            return new VarsServerNameCommand();
        }

        public override string GetValue()
        {
            return "Value";
        }

        public override string GetStringValue()
        {
            return this.GetValue();
        }
    }
}