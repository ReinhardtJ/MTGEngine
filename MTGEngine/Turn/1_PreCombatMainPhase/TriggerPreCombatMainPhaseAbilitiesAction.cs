using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._1_PrecombatMainPhase
{
    public class TriggerPreCombatMainPhaseAbilitiesAction: Action
    {
        public TriggerPreCombatMainPhaseAbilitiesAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("Trigger Pre Combat Main Phase Abilities Action");
        }
    }
}