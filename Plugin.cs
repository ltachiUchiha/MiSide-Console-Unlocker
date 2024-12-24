using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using System;
using UnityEngine;

namespace ItachiPlugin;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    internal static new ManualLogSource Log;


    public override void Load()
    {
        try
        {
            // Plugin startup logic
            Log = base.Log;
            Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
            ClassInjector.RegisterTypeInIl2Cpp<ConsoleUnlocker>();
            AddComponent<ConsoleUnlocker>();

        }
        catch (Exception ex)
        {
            Log.LogError(ex);
        }
    }

}


