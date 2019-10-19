using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1.Models
{
    public static class Repository
    {
        private static int Id = 0;
        private static List<ToolsRequest> responses = new List<ToolsRequest>();


        public static List<Equipment> eList = new List<Equipment>
        {
            new Equipment{ EquipmentID = 1, Type = "Laptop", Description = "Lenovo Thinkpad", Availbility = true},
            new Equipment{ EquipmentID = 2, Type = "Tablet", Description = "Samsung Tablet", Availbility = true },
            new Equipment{ EquipmentID = 3, Type = "Phone", Description = "Samsung S10+", Availbility = true },
            new Equipment{ EquipmentID = 4, Type = "Other", Description = "Specified on form", Availbility = true }
        };

        public static IEnumerable<Equipment> Tools
        {
            get { return eList; }
        }

        public static IEnumerable<ToolsRequest> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(ToolsRequest response)
        {
            if(response.Equipment.ToString() == "Laptop")
            {
                eList.ElementAt(0).Availbility = false;
            }
            else if (response.Equipment.ToString() == "Tablet")
            {
                eList.ElementAt(1).Availbility = false;
            }
            else if (response.Equipment.ToString() == "Phone")
            {
                eList.ElementAt(2).Availbility = false;
            }
            else if(response.Equipment.ToString() == "Other")
            {
                eList.ElementAt(3).Availbility = false;
            }
            Id++;
            response.Id = Id;
            responses.Add(response);
        }
    }
}
