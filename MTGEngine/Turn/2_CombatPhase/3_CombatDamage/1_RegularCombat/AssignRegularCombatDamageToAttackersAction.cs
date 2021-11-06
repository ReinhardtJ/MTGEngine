using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._3_CombatDamage._1_RegularCombat
{
    public class AssignRegularCombatDamageToAttackersAction : Action
    {
        public AssignRegularCombatDamageToAttackersAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("--- Assign regular combat damage to attackers action");
        }
    }
}