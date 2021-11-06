using System.Collections.Generic;

namespace MTGEngine.Turn
{
    public interface ITurnContext
    {

    }
    
    public class TurnContext : ITurnContext
    {
        private int _activePlayerIndex;
        private readonly List<Player> _players;
        private readonly Player _activePlayer;
        private readonly Game _game;
        
        private readonly List<IPhase> _phases;

        public TurnContext(
            List<Player> players, 
            Player activePlayer, 
            Game game,
            List<IPhase> phases)
        {
            _players = players;
            _activePlayer = activePlayer;
            _game = game;
            _phases = phases;
        }
        
        public void StartGame()
        {
            _activePlayerIndex = 0; // TODO(Jonas): choose starting player properly later
            
            // turn loop
            while (true)
            {
                TakeTurn();
                _activePlayerIndex = (_activePlayerIndex + 1) % _players.Count;
            }
        }
        
        private void TakeTurn()
        {
            foreach (var phase in _phases)
            {
                phase.PerformPhase();
            }
        }
    
    }
}