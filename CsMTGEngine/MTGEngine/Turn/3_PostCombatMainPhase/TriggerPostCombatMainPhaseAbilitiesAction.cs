using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._3_PostCombatMainPhase
{
    public class TriggerPostCombatMainPhaseAbilitiesAction : Action
    {
        public TriggerPostCombatMainPhaseAbilitiesAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("- Post Combat Main Phase");
            Console.WriteLine("--- Trigger Post Combat Main Phase Abilities Action");
        }
    }
}