using System;

namespace MTGEngine.Turn
{
    public class TurnManager
    {
        private readonly Game _game;
        private readonly TurnFactory _turnFactory;


        public TurnManager(Game game, TurnFactory turnFactory)
        {
            _game = game;
            _turnFactory = turnFactory;
        }
        
        public void StartGame()
        {
            // turn loop
            while (true)
            {
                Console.WriteLine("Next Step:");
                Console.ReadLine();
                _turnFactory.BaseTurn.TakeTurn();
                _game.UpdateActivePlayer();
            }
        }
    }
}