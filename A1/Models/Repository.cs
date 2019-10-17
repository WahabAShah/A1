using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1.Models
{
    public static class Repository
    {
        private static List<ToolsRequest> responses = new List<ToolsRequest>();

        private static int Id = 0;
        public static IEnumerable<ToolsRequest> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(ToolsRequest response)
        {
            Id++;
            response.Id = Id;
            responses.Add(response);
        }
    }
}
