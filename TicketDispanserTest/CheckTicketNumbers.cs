using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace TicketDispanserTest
{
    [TestClass]
    public class CheckTicketNumbers
    {
        [TestMethod]
        public void Check_Ticket_Numbers()
        {
            /*  
              Explanation:

                The ide of this test among with TestDuplicateTicketNumber is to check if ticket sequnce is correct with multiple created Dispensers.
                We have two created Dispanser and we will have 3 ticket by dispanser.

                This test will make sum of ticket numbers, but previously we make "expectTotalSum" which is simple sum of array numbers (e.g Array[1,2,3] = Sum(6))

                If the sum of both array are equal that menas that ticket numbers are sequnced in correct well.
            */

            TicketDispenserProject.TurnNumberSequence.GlobalTurnNumberSequence.resetTurnNumber();

            List<TicketDispenserProject.TicketDispenser> ticketDispensers = new List<TicketDispenserProject.TicketDispenser> {
                new TicketDispenserProject.TicketDispenser(),
                new TicketDispenserProject.TicketDispenser()
            };

            int ticketsCountPerDispenser = 3;

            int totalTicketCount = ticketDispensers.Count() * ticketsCountPerDispenser;

            int expectTotalSum = GetSum(totalTicketCount);

          
            int resultTotalSum = 0;
               
           
            TicketDispenserProject.TurnTicket turnTicket = null;


            int startIndex = 1;
            
            foreach (TicketDispenserProject.TicketDispenser dispenser in ticketDispensers)
            {
                while (startIndex <= ticketsCountPerDispenser)
                {
                    turnTicket = dispenser.GetTurnTicket();

                    resultTotalSum += turnTicket.TurnNumber;

                    startIndex++;
                }

                startIndex = 1;
            }


            Assert.AreEqual(expectTotalSum, resultTotalSum);
        }

        public int GetSum(int size)
        {
            int sum = 0;

            int startIndex = 1;

            while(startIndex <= size)
            {
                sum += startIndex;

                startIndex++;
            }

            return sum;
        }
    }

  
}
