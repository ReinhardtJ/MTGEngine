using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn.CommonActions
{
    public class ProvideMainPhasePriorityAction: Action
    {
        public ProvideMainPhasePriorityAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("--- Provide Main Phase Priority Action");
        }
    }
}