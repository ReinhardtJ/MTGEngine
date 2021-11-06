using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._4_EndingPhase._0_End
{
    public class TriggerEndStepAbilitiesAction: Action
    {
        public TriggerEndStepAbilitiesAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("Trigger End Step Abilities Action");
        }
    }
}