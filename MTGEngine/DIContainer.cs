using System.Collections.Generic;
using MTGEngine.Turn;

namespace MTGEngine
{
    // TODO(Jonas): Replace with proper DI later
    public class DIContainer
    {
        public static void Inject()
        {
            Player p1 = new Player(1);
            Player p2 = new Player(2);
            var players = new List<Player>() { p1, p2 };
            var game = new Game(players);
            TurnFactory turnFactory = new TurnFactory(game);
            TurnManager turnManager = new TurnManager(game, turnFactory);
            turnManager.StartGame();
        }
    }
}