using System;
namespace TicketDispenserProject
{
    public class TurnTicket
    {
        private readonly int _turnNumber;

        public TurnTicket() : this(TurnNumberSequence.GlobalTurnNumberSequence)
        {
        }

        public TurnTicket(ITurnNumberSequence sequence)
        {
            _turnNumber = sequence.GetNextTurnNumber();
        }

        public int TurnNumber
        {
            get { return _turnNumber; }
        }
    }
}
