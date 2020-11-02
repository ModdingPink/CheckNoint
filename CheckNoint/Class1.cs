using Harmony;
using MelonLoader;
namespace CheckNoint
{
    public class CheckNoint : MelonMod
    {

        public override void OnApplicationStart()
        {
            MelonModLogger.Log("CHECKPOINT IS GONE");
        }

        [HarmonyPatch(typeof(TrackList), "ShouldBeFilteredInList")]
        private static class CHECKPOINTISGONE
        {
            public static void Postfix(TrackList __instance, TrackInfoAssetReference trackInfoAssetRef, ref bool __result)
            {
                if (trackInfoAssetRef.UniqueName == "Checkpoint")
                {
                    __result =  false;
                }
            }
        }
    }
}
