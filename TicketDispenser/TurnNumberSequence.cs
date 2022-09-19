using System;
namespace TicketDispenserProject
{
    public class TurnNumberSequence : ITurnNumberSequence
    {
        private int _turnNumber = 0;

        public static readonly TurnNumberSequence GlobalTurnNumberSequence = new TurnNumberSequence();

        TurnNumberSequence()
        {
            this._turnNumber++;
        }


        public int GetNextTurnNumber()
        {
            return _turnNumber++;
        }


        public void resetTurnNumber()
        {
            _turnNumber = 1;
        }
    }
}
