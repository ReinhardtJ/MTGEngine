using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._2_DeclareBlockers
{
    public class TriggerDeclareBlockersAbilitiesAction : Action
    {
        public TriggerDeclareBlockersAbilitiesAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("--- Trigger Declare Blockers Abilities Action");
        }
    }
}