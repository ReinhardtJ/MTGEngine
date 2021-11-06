using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._1_DeclareAttackers
{
    public class DeclareAttackersAction : Action
    {
        public DeclareAttackersAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("Declare Attackers Action");
        }
    }
}