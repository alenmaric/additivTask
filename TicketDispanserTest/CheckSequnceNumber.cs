using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TicketDispenserProject;

namespace TicketDispanserTest
{
    [TestClass]
    public class CheckSequnceNumber
    {
        private readonly Mock<ITurnNumberSequence> _mockINumberSequnce = new Mock<ITurnNumberSequence>();

        [TestMethod]
        public void Check_Sequnce_Number()
        {
            /*  
              Explanation:  
             
                Test is built to test correct sequnce of ticket numbers. It can be expanded to take some array and check if
                ticket numbers will be in correct sequnce.
            */


            // Arrange & Act
            int expectedSequnceNumber = 1;

            TicketDispenser ticketDispenser = new TicketDispenser();

            _mockINumberSequnce.Setup(numberSequnce => numberSequnce.GetNextTurnNumber()).Returns(expectedSequnceNumber);

            TurnTicket mockTicket = ticketDispenser.GetTurnTicket(_mockINumberSequnce.Object);

      
            TurnTicket turnTicket = ticketDispenser.GetTurnTicket();
           
            //Assert
            Assert.AreEqual(turnTicket.TurnNumber, mockTicket.TurnNumber);
        }
    }
}
