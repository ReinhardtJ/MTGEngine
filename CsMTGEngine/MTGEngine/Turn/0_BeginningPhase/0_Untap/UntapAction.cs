using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._0_BeginningPhase._0_Untap
{
    public class UntapAction: Action
    {
        public UntapAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("--- Untap Action");

        }
    }
}