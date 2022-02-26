using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._4_EndOfCombat
{
    public class RemoveUntilEndOfCombatEffectsAction : Action
    {
        public RemoveUntilEndOfCombatEffectsAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("--- Remove Until End of Combat Effects Action");
        }
    }
}