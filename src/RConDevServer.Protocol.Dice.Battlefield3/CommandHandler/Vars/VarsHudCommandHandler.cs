﻿namespace RConDevServer.Protocol.Dice.Battlefield3.CommandHandler.Vars
{
    public class VarsHudCommandHandler : VarsDefaultBoolCommandHandler
    {
        public override string Command
        {
            get { return RConDevServer.Protocol.Dice.Battlefield3.Constants.COMMAND_VARS_HUD; }
        }
    }
}