using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using MiraAPI;
using MiraAPI.PluginLoading;
using Reactor;
using Reactor.Networking;
using Reactor.Networking.Attributes;

namespace SusByDaylight
{
    // 1. Use standard BepInPlugin instead of BepInAutoPlugin
    [BepInPlugin(Id, Name, Version)]
    [BepInProcess("Among Us.exe")]
    [BepInDependency(ReactorPlugin.Id)]
    [BepInDependency(MiraApiPlugin.Id)]
    [ReactorModFlags(ModFlags.RequireOnAllClients)]

    // 2. Remove the "partial" keyword from the class definition
    public class SusByDaylightPlugin : BasePlugin, IMiraPlugin
    {
        // 3. Manually define your plugin metadata constants here
        public const string Id = "withered.sbd";
        public const string Name = "SusByDaylight";
        public const string Version = "1.0.0";

        // Now 'Id' exists in the current context, so this works perfectly
        public Harmony Harmony { get; } = new(Id);

        public string OptionsTitleText => "Mira API\nSus By Daylight";

        public ConfigFile GetConfigFile() => Config;

        public override void Load()
        {
            Harmony.PatchAll();
        }
    }
}