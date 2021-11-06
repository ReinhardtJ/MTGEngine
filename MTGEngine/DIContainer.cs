using System.Collections.Generic;
using MTGEngine.Turn;

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
            var game = new Game(players);
            TurnFactory turnFactory = new TurnFactory(game);
            TurnManager turnManager = new TurnManager(game, turnFactory);
        }

      
    }
}