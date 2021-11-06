using System.Collections.Generic;
using MTGEngine.Turn;

namespace MTGEngine
{
    public class Game
    {
        private readonly List<Player> _players;
        private readonly Player _activePlayer;

        public Game( List<Player> players, 
            Player activePlayer)
        {
            _players = players;
            _activePlayer = activePlayer;
        }
        
    }
}