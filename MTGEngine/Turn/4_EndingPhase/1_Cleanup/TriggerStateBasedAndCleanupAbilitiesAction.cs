using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._4_EndingPhase._1_Cleanup
{
    public class TriggerStateBasedAndCleanupAbilitiesAction: Action
    {
        public TriggerStateBasedAndCleanupAbilitiesAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("Trigger State Based and Cleanup Abilities Action");
        }
    }
}