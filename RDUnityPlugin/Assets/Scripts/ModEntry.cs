using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

[BepInPlugin("com.author.name","name","1.0.0")]
public class ModEntry : BaseUnityPlugin
{
    public string modPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

    public ManualLogSource ModLogger => base.Logger;
    public static ModEntry instance;
    private AssetBundle scenesBundle;
    private AssetBundle resourcesBundle;
    private Harmony Harmony;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scenesBundle = AssetBundle.LoadFromFile(modPath + "/scenes.assets");
        resourcesBundle = AssetBundle.LoadFromFile(modPath + "/resources.assets");
        Harmony = new Harmony(Info.Metadata.Name);
        Harmony.PatchAll();
    }

    private void OnGUI()
    {
        GUILayout.Label("Hello World");
    }

    [Serializable]
    class MyClass
    {
        string  name;
    }
}
