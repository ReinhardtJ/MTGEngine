using System.Collections.Generic;
using MTGEngine.GameState;

namespace MTGEngine
{
    public class Game
    {
        public Players Players { get; }
        private readonly Battlefield _battlefield;
        private readonly Exile _exile;
        private readonly Graveyards _graveyards;
        private readonly Hands _hands;
        private readonly Libraries _libraries;
        private readonly Lives _lives;

        
        
        public Game(Players players, 
                    Battlefield battlefield, 
                    Exile exile, 
                    Graveyards graveyards, 
                    Hands hands, 
                    Libraries libraries, 
                    Lives lives)
        {
            Players = players;
            _battlefield = battlefield;
            _exile = exile;
            _graveyards = graveyards;
            _hands = hands;
            _libraries = libraries;
            _lives = lives;
        }
        
        
        
      

    }
}