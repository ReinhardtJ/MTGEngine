using System;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._3_CombatDamage._0_FirstAndDoubleStrike
{
    public class SkipSubStepIfNecessaryAction: Action
    {
        public SkipSubStepIfNecessaryAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("-- Combat Damage (First & Double Strike Sub-Step)");
            Console.WriteLine("--- Skip Sub Step If Necessary Action");
        }
    }
}