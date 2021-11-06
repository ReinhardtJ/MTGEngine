using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn.CommonActions
{
    public class EmptyManaPoolAction : Action
    {
        public EmptyManaPoolAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("--- Empty Mana Pool Action");
        }
    }
}