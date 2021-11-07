using System.Collections.Generic;

namespace MTGEngine.GameState
{
    public class Players
    {
        private readonly List<Player> _players;
        
        private Player _activePlayer;
        private int _activePlayerIndex;
        
        public Players(List<Player> players)
        {
            _players = players;
            PostInit();
        }
        
        private void PostInit()
        {
            _activePlayerIndex = 0; // TODO(Jonas): choose starting player properly later
            _activePlayer = _players[_activePlayerIndex];
        }
        
        public void UpdateActivePlayer()
        {
            _activePlayerIndex = (_activePlayerIndex + 1) % _players.Count;
            _activePlayer = _players[_activePlayerIndex];
        }
        
        public Player GetActivePlayer()
        {
            return _activePlayer;
        }
    }
}