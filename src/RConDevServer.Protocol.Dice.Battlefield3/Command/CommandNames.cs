﻿namespace RConDevServer.Protocol.Dice.Battlefield3.Command
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    ///     Repository of command names
    /// </summary>
    public static class CommandNames
    {
        #region PunkBuster

        public const string PunkBusterPbSvCommand = "punkBuster.pb_sv_command";

        public const string PunkBusterActivate = "punkBuster.activate";

        public const string PunkBusterIsActive = "punkBuster.isActive";

        #endregion

        #region MapList

        public const string MapListAvailableMaps = "mapList.availableMaps";

        public const string MapListEndRound = "mapList.endRound";

        public const string MapListRestartRound = "mapList.restartRound";

        public const string MapListRunNextRound = "mapList.runNextRound";

        public const string MapListGetRounds = "mapList.getRounds";

        public const string MapListGetMapIndices = "mapList.getMapIndices";

        public const string MapListSetNextMapIndex = "mapList.setNextMapIndex";

        public const string MapListList = "mapList.list";

        public const string MapListClear = "mapList.clear";

        public const string MapListRemove = "mapList.remove";

        public const string MapListAdd = "mapList.add";

        public const string MapListSave = "mapList.save";

        public const string MapListLoad = "mapList.load";

        #endregion

        #region Admin

        /// <summary>
        ///     Query the effective maximum number of players
        /// </summary>
        public const string AdminEffectiveMaxPlayers = "admin.effectiveMaxPlayers";

        public const string AdminEventsEnabled = "admin.eventsEnabled";

        public const string AdminHelp = "admin.help";

        public const string AdminKickPlayer = "admin.kickPlayer";

        public const string AdminKillPlayer = "admin.killPlayer";

        public const string AdminListPlayers = "admin.listPlayers";

        public const string AdminMovePlayer = "admin.movePlayer";

        public const string AdminSay = "admin.say";

        public const string AdminYell = "admin.yell";

        #endregion

        #region Ban List

        public const string BanListAdd = "banList.add";

        public const string BanListClear = "banList.clear";

        public const string BanListList = "banList.list";

        public const string BanListLoad = "banList.load";

        public const string BanListRemove = "banList.remove";

        public const string BanListSave = "banList.save";

        #endregion

        #region NotAuthenticated

        public const string ServerInfo = "serverInfo";

        public const string ListPlayers = "listPlayers";

        public const string Version = "version";

        public const string Quit = "quit";

        public const string Logout = "logout";

        public const string LoginHashed = "login.hashed";

        public const string LoginPlainText = "login.plainText";

        #endregion

        #region ReservedSlotsList

        public const string ReservedSlotsListAdd = "reservedSlotsList.add";

        public const string ReservedSlotsListAggressiveJoin = "reservedSlotsList.aggressiveJoin";

        public const string ReservedSlotsListClear = "reservedSlotsList.clear";

        public const string ReservedSlotsListList = "reservedSlotsList.list";

        public const string ReservedSlotsListLoad = "reservedSlotsList.load";

        public const string ReservedSlotsListRemove = "reservedSlotsList.remove";

        public const string ReservedSlotsListSave = "reservedSlotsList.save";

        #endregion

        #region Vars

        public const string VarsGunMasterWeaponsPreset = "vars.gunMasterWeaponsPreset";

        public const string VarsPremiumStatus = "vars.premiumStatus";

        public const string VarsUnlockMode = "vars.unlockMode";

        public const string VarsOnlySquadLeaderSpawn = "vars.onlySquadLeaderSpawn";

        public const string VarsGameModeCounter = "vars.gameModeCounter";

        public const string VarsPlayerManDownTime = "vars.playerManDownTime";

        public const string VarsPlayerRespawnTime = "vars.playerRespawnTime";

        public const string VarsSoldierHealth = "vars.soldierHealth";

        public const string VarsVehicleSpawnDelay = "vars.vehicleSpawnDelay";

        public const string VarsVehicleSpawnAllowed = "vars.vehicleSpawnAllowed";

        public const string VarsRoundLockdownCountdown = "vars.roundLockdownCountdown";

        public const string VarsRoundRestartPlayerCount = "vars.roundRestartPlayerCount";

        public const string VarsRoundStartPlayerCount = "vars.roundStartPlayerCount";

        public const string VarsIdleBanRounds = "vars.idleBanRounds";

        public const string VarsTeamKillKickForBan = "vars.teamKillKickForBan";

        public const string VarsIdleTimeout = "vars.idleTimeout";

        public const string VarsTeamKillValueDecreasePerSecond = "vars.teamKillValueDecreasePerSecond";

        public const string VarsTeamKillValueIncrease = "vars.teamKillValueIncrease";

        public const string VarsTeamKillValueForKick = "vars.teamKillValueForKick";

        public const string VarsTeamKillCountForKick = "vars.teamKillCountForKick";

        public const string Vars3PCam = "vars.3pCam";

        public const string VarsNameTag = "vars.nameTag";

        public const string VarsMiniMapSpotting = "vars.miniMapSpotting";

        public const string Vars3DSpotting = "vars.3dSpotting";

        public const string VarsCrossHair = "vars.crossHair";

        public const string VarsHud = "vars.hud";

        public const string VarsMiniMap = "vars.miniMap";

        public const string VarsServerMessage = "vars.serverMessage";

        public const string VarsServerDescription = "vars.serverDescription";

        public const string VarsMaxPlayers = "vars.maxPlayers";

        public const string VarsFriendlyFire = "vars.friendlyFire";

        public const string VarsAutoBalance = "vars.autoBalance";

        public const string VarsGamePassword = "vars.gamePassword";

        public const string VarsServerName = "vars.serverName";

        public const string VarsRanked = "vars.ranked";

        public const string VarsKillCam = "vars.killCam";

        public const string VarsRegenerateHealth = "vars.regenerateHealth";

        public const string VarsBulletDamage = "vars.bulletDamage";

        #endregion
    
        /// <summary>
        /// Returns a list of all available commands
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAll()
        {
            return typeof (CommandNames).GetFields()
                .OrderBy(x => x.Name)
                .Select(field => field.GetRawConstantValue().ToString())
                .ToList();
        }
    }
}