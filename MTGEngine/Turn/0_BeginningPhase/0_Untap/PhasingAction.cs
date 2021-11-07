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
            Console.WriteLine($"Begin Turn for Player {_game.Players.GetActivePlayer()}");
            Console.WriteLine("- Beginning Phase");
            Console.WriteLine("-- Untap Step");
            Console.WriteLine("--- Phasing Action");
        }
    }
}