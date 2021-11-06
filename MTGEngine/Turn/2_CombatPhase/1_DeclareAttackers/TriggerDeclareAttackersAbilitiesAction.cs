using System;
using System.Threading.Channels;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._2_CombatPhase._1_DeclareAttackers
{
    public class TriggerDeclareAttackersAbilitiesAction: Action
    {
        public TriggerDeclareAttackersAbilitiesAction(Game game) : base(game)
        {
        }

        public override void PerformAction()
        {
            Console.WriteLine("Trigger Declare Attackers Abilities Action");
        }
    }
}