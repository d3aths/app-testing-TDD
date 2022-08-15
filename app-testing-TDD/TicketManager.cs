using System;

namespace app_testing_TDD
{
    internal class TicketManager
    {
        public TicketManager()
        {
        }

        internal TicketResponse GetTicket(TicketRequest request)
        {
            //returns the response with the tickets
            return new TicketResponse()
            {
                //the tickets are in this example, an array, because i dont know how to make it choose from a bunch of strings
                Tickets = new TicketType[] { request.Ticket }
                //populate the array with the item from the request
            };
        }
    }
}