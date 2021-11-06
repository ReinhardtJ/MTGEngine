using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._2_DeclareBlockers
{
    public class DeclareBlockersAction : Action
    {
        public DeclareBlockersAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("Declare Blockers Action");
        }
    }
}