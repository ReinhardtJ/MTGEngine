using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._0_BeginningPhase._0_Untap
{
    public class PhasingAction : Action
    {
        public PhasingAction(Game game) : base(game)
        {
        }
        
        public override void PerformAction()
        {
            Console.WriteLine($"Begin Turn for Player {_game.GetActivePlayer()}");
            Console.WriteLine("Phasing Action");
        }
    }
}