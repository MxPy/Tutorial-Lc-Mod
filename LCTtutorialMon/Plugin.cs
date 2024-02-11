using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using LCTtutorialMon.Patches;

namespace LCTtutorialMon{

    [BepInPlugin(modGUID, modName, modVersion)]
    public class TutorialModBase : BaseUnityPlugin{
        private const string modGUID = "Drwhomsdve.LCTutorialMod";
        private const string modName = "LCTutorialModName";
        private const string modVersion = "1.0.0.1";

        private readonly Harmony harmony = new Harmony(modGUID);
        private static TutorialModBase? Instance;
        internal ManualLogSource? mls;
        private void Awake(){
            if (Instance == null){
                Instance = this;
            }
            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            mls.LogInfo("Test - Hello World");
            harmony.PatchAll(typeof(TutorialModBase));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
        }

    }
}

    
