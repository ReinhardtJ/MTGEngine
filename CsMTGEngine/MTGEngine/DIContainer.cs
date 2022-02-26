using System.Collections.Generic;
using MTGEngine.GameState;
using MTGEngine.Turn;

namespace MTGEngine
{
    // TODO(Jonas): Replace with proper DI later
    public class DIContainer
    {
        public static void Inject()
        {
            var p1 = new Player(1);
            var p2 = new Player(2);
            var players = new Players(new List<Player>(2) { p1, p2 });
            
            
            var battlefield = new Battlefield();
            var exile = new Exile();
            var graveyards = new Graveyards();
            var hands = new Hands();
            var libraries = new Libraries();
            var lives = new Lives();
            var game = new Game(players, 
                                battlefield,
                                exile,
                                graveyards,
                                hands,
                                libraries,
                                lives);
            var turnFactory = new TurnFactory(game);
            var turnManager = new TurnManager(game, turnFactory);
            turnManager.StartGame();
        }
    }
}