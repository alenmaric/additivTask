using System;

namespace TicketDispenserProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            About Task:
                - I realize that if we create multiple Dispenser object and create some tickets
                  there will be ticket if sam ticket_number which is, in my opninion, not good
                  because that is only identificator of ticket.

                - I did some changes to TurnNumberSequnce to increase ticket_number depends on how many dispenser we have created.
            */
            TicketDispenser ticketDispenser = new TicketDispenser();

            TurnTicket ticket1 = ticketDispenser.GetTurnTicket();
            TurnTicket ticket2 = ticketDispenser.GetTurnTicket();
            TurnTicket ticket3 = ticketDispenser.GetTurnTicket();

            TicketDispenser ticketDispenser2 = new TicketDispenser();

            TurnTicket ticket4 = ticketDispenser2.GetTurnTicket();
            TurnTicket ticket5 = ticketDispenser2.GetTurnTicket();
            TurnTicket ticket6 = ticketDispenser2.GetTurnTicket();

            Console.WriteLine("Ticket number shold be 1. Result: " + ticket1.TurnNumber);
            Console.WriteLine("Ticket number shold be 2. Result: " + ticket2.TurnNumber);
            Console.WriteLine("Ticket number shold be 3. Result: " + ticket3.TurnNumber);

            Console.WriteLine("Ticket number shold be 4. Result:" + ticket4.TurnNumber);
            Console.WriteLine("Ticket number shold be 5. Result: " + ticket5.TurnNumber);
            Console.WriteLine("Ticket number shold be 6. Result: " + ticket6.TurnNumber);
        }
    }
}
