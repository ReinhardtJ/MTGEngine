using System.Collections.Generic;
using MTGEngine.Priority;

namespace MTGEngine.GameState
{
    public class Player
    {
        private readonly int _id;
 
        public Player(int id)
        {
            _id = id;
        }

        public override string ToString()
        {
            return _id.ToString();
        }
        
        public void ReceivePriority(ISet<Interaction> possibleInteractions)
        {
            
        }
    }
}