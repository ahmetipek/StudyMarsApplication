using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMarsApplication.Models
{
    public static class DirectionDefinition
    {
        public static List<DirectionInfo> DirectionDefinitionList = new List<DirectionInfo>  { 
                new DirectionInfo { FromDirection = "E", TurnValue = "L", ToDirection = "S" },
                new DirectionInfo { FromDirection = "E", TurnValue = "R", ToDirection = "N" },
                new DirectionInfo { FromDirection = "W", TurnValue = "L", ToDirection = "N" },
                new DirectionInfo { FromDirection = "W", TurnValue = "R", ToDirection = "S" },
                new DirectionInfo { FromDirection = "N", TurnValue = "R", ToDirection = "W" },
                new DirectionInfo { FromDirection = "N", TurnValue = "L", ToDirection = "E" }, 
                new DirectionInfo { FromDirection = "S", TurnValue = "L", ToDirection = "W" },
                new DirectionInfo { FromDirection = "S", TurnValue = "R", ToDirection = "E" } 
            };
    }
}


