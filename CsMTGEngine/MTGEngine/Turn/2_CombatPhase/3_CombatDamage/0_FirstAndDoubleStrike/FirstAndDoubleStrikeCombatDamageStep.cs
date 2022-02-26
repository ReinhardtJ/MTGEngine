using System;
using System.Collections.Generic;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._3_CombatDamage._0_FirstAndDoubleStrike
{
    public class FirstAndDoubleStrikeCombatDamageStep : Step
    {
        public FirstAndDoubleStrikeCombatDamageStep(List<Action> actions) : base(actions)
        {
        }
    }
}