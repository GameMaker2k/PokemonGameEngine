﻿using Kermalis.PokemonBattleEngine.Data;

namespace Kermalis.PokemonGameEngine.Pkmn
{
    internal sealed class EVs : IPBEStatCollection
    {
        public byte HP { get; set; }
        public byte Attack { get; set; }
        public byte Defense { get; set; }
        public byte SpAttack { get; set; }
        public byte SpDefense { get; set; }
        public byte Speed { get; set; }

        public void CopyFrom(IPBEReadOnlyStatCollection other)
        {
            HP = other.HP;
            Attack = other.Attack;
            Defense = other.Defense;
            SpAttack = other.SpAttack;
            SpDefense = other.SpDefense;
            Speed = other.Speed;
        }
    }

    internal sealed class IVs : IPBEReadOnlyStatCollection
    {
        public byte HP { get; }
        public byte Attack { get; }
        public byte Defense { get; }
        public byte SpAttack { get; }
        public byte SpDefense { get; }
        public byte Speed { get; }
    }
}
