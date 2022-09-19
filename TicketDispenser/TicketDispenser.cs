using System;
namespace TicketDispenserProject
{
    public class TicketDispenser
    {
        
        public TurnTicket GetTurnTicket()
        {
            return new TurnTicket();
        }

        // created to be able to implement test
        public TurnTicket GetTurnTicket(ITurnNumberSequence turnNumberSequence)
        {
            return new TurnTicket(turnNumberSequence);
        }
    }
}
