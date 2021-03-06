﻿namespace RConDevServer.Protocol.Dice.Battlefield3.Data
{
    using System;

    public class GameMode : IEquatable<GameMode>
    {
        public virtual string Code { get; set; }

        public virtual string Display { get; set; }

        public virtual int MaxPlayerCount { get; set; }

        public virtual GameMode Instance
        {
            get { return this; }
        }

        public virtual long Key { get; set; }

        public virtual bool Equals(GameMode other)
        {
            return this.Code == other.Code;
        }

        public virtual string ToWord()
        {
            return this.Code ?? string.Empty;
        }

        public override bool Equals(object obj)
        {
            if (obj is GameMode)
            {
                return this.Equals(obj as GameMode);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (this.Code != null ? this.Code.GetHashCode() : 0);
        }
    }
}