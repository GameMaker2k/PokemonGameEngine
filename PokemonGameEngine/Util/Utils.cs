﻿using Kermalis.PokemonBattleEngine.Data;
using Kermalis.PokemonGameEngine.Core;
using Kermalis.PokemonGameEngine.Item;
using System.IO;
using System.Reflection;

namespace Kermalis.PokemonGameEngine.Util
{
    internal static class Utils
    {
        private const string AssemblyPrefix = "Kermalis.PokemonGameEngine.Assets.";
        private static readonly Assembly _assembly = Assembly.GetExecutingAssembly();
        public static Stream GetResourceStream(string resource)
        {
            return _assembly.GetManifestResourceStream(AssemblyPrefix + resource);
        }

        public static string WorkingDirectory { get; private set; }
        public static void SetWorkingDirectory(string workingDirectory)
        {
            PBEDataProvider.InitEngine(workingDirectory, dataProvider: new BattleEngineDataProvider());
            WorkingDirectory = workingDirectory;
        }

        public static bool GetRandomShiny()
        {
            bool hasCharm = Game.Instance.Save.PlayerInventory[ItemPouchType.KeyItems][(PBEItem)632] != null; // 632 is Shiny Charm
            return PBEDataProvider.GlobalRandom.RandomBool(hasCharm ? 3 : 1, 8192);
        }
    }
}
