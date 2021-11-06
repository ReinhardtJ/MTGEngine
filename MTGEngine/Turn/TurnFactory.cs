using System.Collections.Generic;
using MTGEngine.Turn._0_BeginningPhase;
using MTGEngine.Turn._0_BeginningPhase._0_Untap;
using MTGEngine.Turn._0_BeginningPhase._1_Upkeep;
using MTGEngine.Turn._0_BeginningPhase._2_Draw;
using MTGEngine.Turn._1_PrecombatMainPhase;
using MTGEngine.Turn._2_CombatPhase;
using MTGEngine.Turn._2_CombatPhase._0_BeginCombat;
using MTGEngine.Turn._2_CombatPhase._1_DeclareAttackers;
using MTGEngine.Turn._2_CombatPhase._2_DeclareBlockers;
using MTGEngine.Turn._2_CombatPhase._3_CombatDamage._0_FirstAndDoubleStrike;
using MTGEngine.Turn._2_CombatPhase._3_CombatDamage._1_RegularCombat;
using MTGEngine.Turn._2_CombatPhase._3_CombatDamage.CommonActions;
using MTGEngine.Turn._2_CombatPhase._4_EndOfCombat;
using MTGEngine.Turn._3_PostCombatMainPhase;
using MTGEngine.Turn._4_EndingPhase;
using MTGEngine.Turn._4_EndingPhase._0_End;
using MTGEngine.Turn._4_EndingPhase._1_Cleanup;
using MTGEngine.Turn.CommonActions;

namespace MTGEngine.Turn
{
    public class TurnFactory
    {
        private Game _game;
        private Turn _baseTurn;
        public Turn BaseTurn => _baseTurn;
        
        public TurnFactory(Game game)
        {
            _game = game;
            _baseTurn = BuildTurn();
        }
        
        private Turn BuildTurn()
        {
            return new Turn(new List<IPhase>(5)
            {
                new BeginningPhase(new List<Step>
                {
                    new UntapStep(new List<Action>(3)
                    {
                        new PhasingAction(_game),
                        new UntapAction(_game),
                        new EmptyManaPoolAction(_game)
                    }),
                    new UpkeepStep(new List<Action>(3)
                    {
                        new TriggerUpkeepAbilitiesAction(_game),
                        new ProvideInstantPriorityAction(_game),
                        new EmptyManaPoolAction(_game)
                    }),
                    new DrawStep(new List<Action>(4)
                    {
                        new DrawAction(_game),
                        new TriggerDrawStepAbilitiesAction(_game),
                        new ProvideInstantPriorityAction(_game),
                        new EmptyManaPoolAction(_game)
                    })
                }),
                new PreCombatMainPhase(new List<Action>(3)
                {
                    new TriggerPreCombatMainPhaseAbilitiesAction(_game),
                    new ProvideMainPhasePriorityAction(_game),
                    new EmptyManaPoolAction(_game)
                }),
                new CombatPhase(new List<Step>(6)
                {
                    new BeginCombatStep(new List<Action>(3)
                    {
                        new TriggerBeginCombatAbilitiesAction(_game),
                        new ProvideInstantPriorityAction(_game),
                        new EmptyManaPoolAction(_game)
                    }),
                    new DeclareAttackersStep(new List<Action>(4)
                    {
                        new DeclareAttackersAction(_game),
                        new TriggerDeclareAttackersAbilitiesAction(_game),
                        new ProvideInstantPriorityAction(_game),
                        new EmptyManaPoolAction(_game)
                    }),
                    new DeclareBlockersStep(new List<Action>(8)
                    {
                        new DeclareBlockersAction(_game),
                        new DeclareDamageOrderToBlockersAction(_game),
                        new DeclareDamageOrderToAttackersAction(_game),
                        new TriggerDeclareBlockersAbilitiesAction(_game),
                        new ProvideInstantPriorityAction(_game),
                        new DeclareDamageOrderOfTriggeredBlockersAction(_game),
                        new DeclareDamageOrderOfETBBlockersAction(_game),
                        new EmptyManaPoolAction(_game)
                    }),
                    new FirstAndDoubleStrikeCombatDamageStep(new List<Action>(8)
                    {
                        new SkipSubStepIfNecessaryAction(_game),
                        new AssignFirstStrikeCombatDamageToBlockersAction(_game),
                        new AssignFirstStrikeCombatDamageToPlayersAction(_game),
                        new AssignFirstStrikeCombatDamageToAttackersAction(_game),
                        new DealCombatDamageAction(_game),
                        new TriggerDealsAndIsDealtCombatDamageAbilitiesAction(_game),
                        new ProvideInstantPriorityAction(_game),
                        new EmptyManaPoolAction(_game)
                    }),
                    new RegularCombatDamageStep(new List<Action>(7)
                    {
                        new AssignRegularCombatDamageToBlockersAction(_game),
                        new AssignRegularCombatDamageToPlayersAction(_game),
                        new AssignRegularCombatDamageToAttackersAction(_game),
                        new DealCombatDamageAction(_game),
                        new TriggerDealsAndIsDealtCombatDamageAbilitiesAction(_game),
                        new ProvideInstantPriorityAction(_game),
                        new EmptyManaPoolAction(_game),
                    }),
                    new EndOfCombatStep(new List<Action>(5)
                    {
                        new TriggerEndOfCombatAbilitiesAction(_game),
                        new ProvideInstantPriorityAction(_game),
                        new RemoveCreaturesAndPlaneswalkersFromCombatAction(_game),
                        new RemoveUntilEndOfCombatEffectsAction(_game),
                        new EmptyManaPoolAction(_game)
                    })
                }),
                new PostCombatMainPhase(new List<Action>(3)
                {
                    new TriggerPostCombatMainPhaseAbilitiesAction(_game),
                    new ProvideMainPhasePriorityAction(_game),
                    new EmptyManaPoolAction(_game),
                }),
                new EndingPhase(new List<Step>(2)
                {
                    new EndStep(new List<Action>(3)
                    {
                        new TriggerEndStepAbilitiesAction(_game),
                        new ProvideInstantPriorityAction(_game),
                        new EmptyManaPoolAction(_game)
                    }),
                    new CleanupStep(new List<Action>(7)
                    {
                        new DiscardToMaximumHandSizeAction(_game),
                        new RemoveDamageAndTurnEffectsAction(_game),
                        new TriggerStateBasedAndCleanupAbilitiesAction(_game),
                        new EndCleanupStepIfPossibleAction(_game),
                        new ProvideInstantPriorityAction(_game),
                        new EmptyManaPoolAction(_game),
                        new RepeatCleanupStepAction(_game)
                    })
                })
            });
        }
    }
}