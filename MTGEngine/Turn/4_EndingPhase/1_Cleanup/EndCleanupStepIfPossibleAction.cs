using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._4_EndingPhase._1_Cleanup
{
    public class EndCleanupStepIfPossibleAction: Action
    {
        public EndCleanupStepIfPossibleAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("--- End Cleanup Step if possible action");
        }
    }
}