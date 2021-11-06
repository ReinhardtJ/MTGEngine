using System.Collections.Generic;

namespace MTGEngine.Turn
{
    public abstract class Phase : IPhase
    {
        private List<Step> _steps;

        protected Phase(List<Step> steps)
        {
            _steps = steps;
        }

        public void PerformPhase()
        {
            foreach (var step in _steps)
            {
                step.PerformStep();
            }
        }
    }
}