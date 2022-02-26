using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._4_EndOfCombat
{
    public class TriggerEndOfCombatAbilitiesAction : Action
    {
        public TriggerEndOfCombatAbilitiesAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("-- End of Combat Step");
            Console.WriteLine("--- Trigger End of Combat Abilities Action");
        }
    }
}