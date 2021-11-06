namespace MTGEngine.Turn
{
    public abstract class Action
    {
        
        public Action(Game game)
        {
            
        }
        public abstract void PerformAction();
    }
}