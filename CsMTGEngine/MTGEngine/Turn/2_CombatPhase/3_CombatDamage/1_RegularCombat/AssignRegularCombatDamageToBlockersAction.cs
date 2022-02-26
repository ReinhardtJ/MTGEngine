using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._3_CombatDamage._1_RegularCombat
{
    public class AssignRegularCombatDamageToBlockersAction : Action
    {
        public AssignRegularCombatDamageToBlockersAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("-- Combat Damage (Regular Combat Damage Sub-Step)");
            Console.WriteLine("--- Assign regular combat damage to blockers action");
        }
    }
}