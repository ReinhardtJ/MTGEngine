using System.Collections.Generic;
using MTGEngine.Turn;
using MTGEngine.Turn._0_BeginningPhase;
using MTGEngine.Turn._0_BeginningPhase._0_Untap;
using MTGEngine.Turn._0_BeginningPhase._1_Upkeep;
using MTGEngine.Turn._0_BeginningPhase._2_Draw;
using MTGEngine.Turn._1_PrecombatMainPhase;
using MTGEngine.Turn._2_CombatPhase;
using MTGEngine.Turn._2_CombatPhase._0_BeginCombat;
using MTGEngine.Turn._2_CombatPhase._1_DeclareAttackers;
using MTGEngine.Turn._2_CombatPhase._2_DeclareBlockers;
using MTGEngine.Turn._2_CombatPhase._3_CombatDamage;
using MTGEngine.Turn._2_CombatPhase._3_CombatDamage._0_FirstAndDoubleStrike;
using MTGEngine.Turn._2_CombatPhase._3_CombatDamage._1_RegularCombat;
using MTGEngine.Turn._2_CombatPhase._4_EndOfCombat;
using MTGEngine.Turn._3_PostCombatMainPhase;
using MTGEngine.Turn._4_EndingPhase;
using MTGEngine.Turn._4_EndingPhase._0_End;
using MTGEngine.Turn._4_EndingPhase._1_Cleanup;
using MTGEngine.Turn.CommonActions;

namespace MTGEngine
{
    // TODO(Joans): Replace with proper DI later
    public class DIContainer
    {
        public static void Inject()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            var players = new List<Player>() { p1, p2 };
            var activePlayer = p1;
            var game = new Game(players, activePlayer);
            List<IPhase> phases = BuildGamePhases(game);
            TurnContext turnContext = new TurnContext(
                players,
                activePlayer,
                game,
                phases
                );
        }

        private static List<IPhase> BuildGamePhases(Game game)
        {
            return new()
            {
                new BeginningPhase(new List<Step>
                {
                    new UntapStep(new List<Action>(3)
                    {
                        new PhasingAction(game),
                        new UntapAction(game),
                        new EmptyManaPoolAction(game)
                    }),
                    new UpkeepStep(new List<Action>(3)
                    {
                        new TriggerUpkeepAbilitiesAction(game),
                        new ProvideInstantPriorityAction(game),
                        new EmptyManaPoolAction(game)
                    }),
                    new DrawStep(new List<Action>(4)
                    {
                        new DrawAction(game),
                        new TriggerDrawStepAbilitiesAction(game),
                        new ProvideInstantPriorityAction(game),
                        new EmptyManaPoolAction(game)
                    })
                }),
                new PreCombatMainPhase(new List<Action>(3)
                {
                    new TriggerPreCombatMainPhaseAbilitiesAction(game),
                    new ProvideMainPhasePriorityAction(game),
                    new EmptyManaPoolAction(game)
                }),
                new CombatPhase(new List<Step>(6)
                {
                    new BeginCombatStep(new List<Action>(3)
                    {
                        new TriggerBeginCombatAbilitiesAction(game),
                        new ProvideInstantPriorityAction(game),
                        new EmptyManaPoolAction(game)
                    }),
                    new DeclareAttackersStep(new List<Action>(4)
                    {
                        new DeclareAttackersAction(game),
                        new TriggerDeclareAttackersAbilitiesAction(game),
                        new ProvideInstantPriorityAction(game),
                        new EmptyManaPoolAction(game)
                    }),
                    new DeclareBlockersStep(new List<Action>(8)
                    {
                        new DeclareBlockersAction(game),
                        new DeclareDamageOrderToBlockersAction(game),
                        new DeclareDamageOrderToAttackersAction(game),
                        new TriggerDeclareBlockersAbilitiesAction(game),
                        new ProvideInstantPriorityAction(game),
                        new DeclareDamageOrderOfTriggeredBlockersAction(game),
                        new DeclareDamageOrderOfETBBlockersAction(game),
                        new EmptyManaPoolAction(game)
                    }),
                    new FirstAndDoubleStrikeCombatDamageStep(new List<Action>(8)
                    {
                        new SkipSubStepIfNecessaryAction(game),
                        new AssignFirstStrikeCombatDamageToBlockersAction(game),
                        new AssignFirstStrikeCombatDamageToPlayersAction(game),
                        new AssignFirstStrikeCombatDamageToAttackersAction(game),
                        new DealCombatDamageAction(game),
                        new TriggerDealsAndIsDealtCombatDamageAbilitiesAction(game),
                        new ProvideInstantPriorityAction(game),
                        new EmptyManaPoolAction(game)
                    }),
                    new RegularCombatDamageStep(new List<Action>(7)
                    {
                        new AssignRegularCombatDamageToBlockersAction(game),
                        new AssignRegularCombatDamageToPlayersAction(game),
                        new AssignRegularCombatDamageToAttackersAction(game),
                        new DealCombatDamageAction(game),
                        new TriggerDealsAndIsDealtCombatDamageAbilitiesAction(game),
                        new ProvideInstantPriorityAction(game),
                        new EmptyManaPoolAction(game),
                    }),
                    new EndOfCombatStep(new List<Action>(5)
                    {
                        new TriggerEndOfCombatAbilitiesAction(game),
                        new ProvideInstantPriorityAction(game),
                        new RemoveCreaturesAndPlaneswalkersFromCombatAction(game),
                        new RemoveUntilEndOfCombatEffectsAction(game),
                        new EmptyManaPoolAction(game)
                    })
                }),
                new PostCombatMainPhase(new List<Action>(3)
                {
                    new TriggerEndStepAbilitiesAction(game),
                    new ProvideMainPhasePriorityAction(game),
                    new EmptyManaPoolAction(game),
                }),
                new EndingPhase(new List<Step>(2)
                {
                    new EndStep(new List<Action>(3)
                    {
                        new TriggerEndStepAbilitiesAction(game),
                        new ProvideInstantPriorityAction(game),
                        new EmptyManaPoolAction(game)
                    }),
                    new CleanupStep(new List<Action>(7)
                    {
                        new DiscardToMaximumHandSizeAction(game),
                        new RemoveDamageAndTurnEffectsAction(game),
                        new TriggerStateBasedAndCleanupAbilitiesAction(game),
                        new EndCleanupStepIfPossibleAction(game),
                        new ProvideInstantPriorityAction(game),
                        new EmptyManaPoolAction(game),
                        new RepeatCleanupStepAction(game)
                    })
                })
            };
        }
    }
}