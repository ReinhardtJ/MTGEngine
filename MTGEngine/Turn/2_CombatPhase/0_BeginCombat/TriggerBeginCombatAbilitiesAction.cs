using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._0_BeginCombat
{
    public class TriggerBeginCombatAbilitiesAction: Action
    {
        public TriggerBeginCombatAbilitiesAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("- Combat Phase");
            Console.WriteLine("-- Beginning of Combat");
            Console.WriteLine("--- Trigger Begin Combat Abilities Action");
        }
    }
}