using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._4_EndingPhase._1_Cleanup
{
    public class DiscardToMaximumHandSizeAction : Action
    {
        public DiscardToMaximumHandSizeAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("Discard to maximum hand size action");
        }
    }
}