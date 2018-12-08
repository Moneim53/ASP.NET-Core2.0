using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();//making a list of GuestResonse Class

        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses; //GET The List To Use It in HomeController
            }
        }

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
