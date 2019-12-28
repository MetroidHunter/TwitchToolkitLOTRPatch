using ToolkitPatchLib;
using Verse;

namespace ToolkitLordOfTheRimsPatch
{
    public class ToolkitLordOfTheRimsPatch : Mod
    {
        public ToolkitLordOfTheRimsPatch(ModContentPack content) : base(content)
        {
            Logger.LOGGERNAME = "TLOTR";
        }

        public override string SettingsCategory() => "Toolkit LOTR Patch";
    }
}
