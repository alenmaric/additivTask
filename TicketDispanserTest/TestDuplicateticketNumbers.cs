using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketDispanserTest
{
    [TestClass]
    public class TestDuplicateticketNumbers
    {
        [TestMethod]
        public void Test_Duplicate_Ticket_Numbers()
        {

            /*  
              Explanation:

                After CheckTicketNumbers test I build this one to check for duplicates in ticket arrays,
                because CheckTicketNumbers can count only sum, but let's se next case

                    - CheckTicketNumber: => 1,2,3,4,5 = 15 , lets explain this case 1,2,4,4,4 = 15, so in both cases test will be succeded

                By this test we will check if there is duplicates in ticket numbers created by Dispenser
            */

            TicketDispenserProject.TurnNumberSequence.GlobalTurnNumberSequence.resetTurnNumber();


            int ticketCount = 10;


            List<int> ticketNumbers = getTicketNumbers(ticketCount);


            IEnumerable<int> duplicates = ticketNumbers.GroupBy(x => x)
                                        .Where(g => g.Count() > 1)
                                        .Select(x => x.Key);

            bool valid = true;

            if (duplicates.Count() > 0)
                valid = false;



            Assert.IsTrue(valid);
        }

        public List<int> getTicketNumbers(int ticketsCount)
        {
            List<int> ticketNumbers = new List<int>();

            if (ticketsCount <= 0)
                return ticketNumbers;

            TicketDispenserProject.TicketDispenser dispenser = new TicketDispenserProject.TicketDispenser();

            TicketDispenserProject.TurnTicket turnTicket = new TicketDispenserProject.TurnTicket();


            int index = 1;

            while (index <= ticketsCount)
            {
                turnTicket = dispenser.GetTurnTicket();

                ticketNumbers.Add(turnTicket.TurnNumber);

                index++;
            }

            return ticketNumbers;

        }
    }
}
