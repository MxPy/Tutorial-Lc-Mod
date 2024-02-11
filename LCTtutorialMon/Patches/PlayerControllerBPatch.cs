using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNetcodeStuff;
using HarmonyLib;

namespace LCTtutorialMon.Patches{

    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch{

        //[HarmonyPatch(nameof(PlayerControllerB.))] if we can acces method
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        private static void infSprintPatch(ref float ___sprintMeter){
            ___sprintMeter = 1f;
        }
    }
}
