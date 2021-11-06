namespace MTGEngine.Turn.BaseClasses
{
    public abstract class Action
    {
        protected readonly Game _game;

        public Action(Game game)
        {
            _game = game;
        }
        public abstract void PerformAction();
    }
}