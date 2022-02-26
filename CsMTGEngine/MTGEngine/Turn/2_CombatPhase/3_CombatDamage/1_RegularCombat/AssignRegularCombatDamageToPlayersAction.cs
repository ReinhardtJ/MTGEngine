using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._3_CombatDamage._1_RegularCombat
{
    public class AssignRegularCombatDamageToPlayersAction : Action
    {
        public AssignRegularCombatDamageToPlayersAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("--- Assign regular combat damage to players action");
        }
    }
}