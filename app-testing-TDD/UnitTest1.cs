using NUnit.Framework;

namespace app_testing_TDD
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //method name is what we want to test for, so getting the ticket and showing what age it comes under
        public void GetTicketType()
        {
            //the data we want to process
            var ticket = new TicketType()
            {   
                //set the properties of the object
                Age = "Child"
            };

            //a request that we will use the previous object in
            var request = new TicketRequest()
            {
                //set the properties of the request, the object we want to send in it
                Ticket = ticket
            };

            //instantiating the manager
            var manager = new TicketManager();

            //the data that is coming back from the quest
            //TicketResponse should return the age of ticket
            TicketResponse response = manager.GetTicket(request);

            //checking if the response actually contains something (not null)
            Assert.IsNotNull(response);
            //checks if the response is actually part of the array of tickets (from example, not applicable for this bc we wont work with an array i think
            Assert.Contains(ticket, response.Tickets);
        }
    }
}