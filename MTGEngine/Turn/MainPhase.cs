using System.Collections.Generic;

namespace MTGEngine.Turn
{
    public abstract class MainPhase: IPhase
    {
        private readonly List<Action> _actions;

        public MainPhase(List<Action> actions)
        {
            _actions = actions;
        }
        public void PerformPhase()
        {
            foreach (var action in _actions)
            {
                action.PerformAction();
            }
        }
    }
}