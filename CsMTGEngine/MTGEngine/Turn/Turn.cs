using System.Collections.Generic;

namespace MTGEngine.Turn
{
    public class Turn
    {
        private readonly List<IPhase> _phases;

        public Turn(List<IPhase> phases)
        {
            _phases = phases;
        }
        
        public void TakeTurn()
        {
            foreach (var phase in _phases)
            {
                phase.PerformPhase();
            }
        }
    }
}