using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._3_CombatDamage._0_FirstAndDoubleStrike
{
    public class AssignFirstStrikeCombatDamageToBlockersAction: Action
    {
        public AssignFirstStrikeCombatDamageToBlockersAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("--- Assign First Strike Combat Damage To Blockers Action");
        }
    }
}