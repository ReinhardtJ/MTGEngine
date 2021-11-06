using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._0_BeginningPhase._2_Draw
{
    public class TriggerDrawStepAbilitiesAction : Action
    {
        public TriggerDrawStepAbilitiesAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("--- Trigger Draw Step Abilities Action");
        }
    }
}