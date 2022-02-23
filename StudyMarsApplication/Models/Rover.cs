using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMarsApplication.Models
{
   public class Rover
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Direction { get; set; }
        public string CommandList { get; set; }
        public Rover()
        {

        }
        public Rover(int XCoordinate, int YCoordinate, string Direction, string CommandList)
       {
           this.XCoordinate = XCoordinate;
           this.YCoordinate = YCoordinate;
           this.Direction = Direction;
           this.CommandList = CommandList;
       }
    }
}
