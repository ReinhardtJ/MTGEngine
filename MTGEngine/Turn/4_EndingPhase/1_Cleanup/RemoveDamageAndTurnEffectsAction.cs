using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._4_EndingPhase._1_Cleanup
{
    public class RemoveDamageAndTurnEffectsAction: Action
    {
        public RemoveDamageAndTurnEffectsAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("Remove Damage and Turn effects action");
        }
    }
}