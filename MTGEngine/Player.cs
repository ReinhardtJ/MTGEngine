using System;

namespace MTGEngine
{
    public class Player
    {
        private int _id;
 
        public Player(int id)
        {
            _id = id;
        }

        public override string ToString()
        {
            return _id.ToString();
        }
    }
}