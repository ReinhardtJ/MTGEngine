using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._0_BeginningPhase._1_Upkeep
{
    public class TriggerUpkeepAbilitiesAction : Action
    {
        public TriggerUpkeepAbilitiesAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("-- Upkeep Step");
            Console.WriteLine("--- Trigger Upkeep Abilities Action");
        }
    }
}