using Dwarves;
using RimWorld;
using ToolkitPatchLib;
using Verse;

namespace ToolkitLordOfTheRimsPatch
{
    public class IncidentHelper_AncientDwarvenStronghold : NormalIncidentHelper<IncidentWorker_AncientDwarvenStronghold>
    {
        public IncidentHelper_AncientDwarvenStronghold() : base(IncidentCategoryDefOf.Misc, IncidentDef.Named("LotRD_QuestAncientStronghold"), Find.World, true) { }
    }

    public class VoteHelper_AncientDwarvenStronghold : BasicVotingHelper<IncidentWorker_AncientDwarvenStronghold>
    {
        public VoteHelper_AncientDwarvenStronghold() : base(IncidentCategoryDefOf.Misc, IncidentDef.Named("LotRD_QuestAncientStronghold"), true) { }
    }
}
