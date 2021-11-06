using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._3_CombatDamage.CommonActions
{
    public class DealCombatDamageAction : Action
    {
        public DealCombatDamageAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("Deal combat Damage action");
        }
    }
}