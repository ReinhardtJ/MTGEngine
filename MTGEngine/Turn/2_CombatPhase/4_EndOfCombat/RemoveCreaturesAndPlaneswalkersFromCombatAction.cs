using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._4_EndOfCombat
{
    public class RemoveCreaturesAndPlaneswalkersFromCombatAction : Action
    {
        public RemoveCreaturesAndPlaneswalkersFromCombatAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("Remove Creatures And Planeswalkers from Combat Action");
        }
    }
}