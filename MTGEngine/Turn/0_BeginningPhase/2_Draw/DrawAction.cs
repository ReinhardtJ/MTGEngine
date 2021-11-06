using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._0_BeginningPhase._2_Draw
{
    public class DrawAction : Action
    {
        public DrawAction(Game game) : base(game)
        {
            
        }

        public override void PerformAction()
        {
            Console.WriteLine("Draw Action");
        }
    }
}