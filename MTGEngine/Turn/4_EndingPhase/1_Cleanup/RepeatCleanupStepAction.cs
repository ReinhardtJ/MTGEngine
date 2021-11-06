using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._4_EndingPhase._1_Cleanup
{
    public class RepeatCleanupStepAction: Action
    {
        public RepeatCleanupStepAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("Repeat Cleanup Step Action");
        }
    }
}