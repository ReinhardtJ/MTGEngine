using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn.CommonActions
{
    public class ProvideInstantPriorityAction : Action
    {
        public ProvideInstantPriorityAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("--- Provide Instant Priority Action");
        }
    }
}