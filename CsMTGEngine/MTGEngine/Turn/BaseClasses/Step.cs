using System.Collections.Generic;
using MTGEngine.Turn.BaseClasses;

namespace MTGEngine.Turn
{
    public class Step
    {
        private readonly List<Action> _actions;

        protected Step(List<Action> actions)
        {
            _actions = actions;
        }
        public void PerformStep()
        {
            foreach (var action in _actions)
            {
                action.PerformAction();
            }
        }
    }
}