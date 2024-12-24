using System;
using BepInEx.Unity.IL2CPP.UnityEngine;
using UnityEngine;


public class ConsoleUnlocker : MonoBehaviour
{
    public ConsoleUnlocker(IntPtr handle) : base(handle) { }

    public void Start()
    {
        if (ConsoleMain.liteVersion)
        {
            ConsoleMain.liteVersion = false;
        }

    }

    void Update()
    {
        if (ConsoleMain.liteVersion)
        {
            ConsoleMain.liteVersion = false;
        }
    }

    void OnApplicationQuit()
    {
        ConsoleMain.active = false;
        ConsoleMain.liteVersion = true;
    }
}