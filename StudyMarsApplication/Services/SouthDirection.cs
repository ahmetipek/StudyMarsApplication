using StudyMarsApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMarsApplication.Services
{
    public class SouthDirection :Direction, IRoverCalculator
    {
        public SouthDirection(Rover Rover, int SideLength)
            : base(Rover,SideLength)
        {
        }
        public void Calculate()
        {
            if (this.Rover.YCoordinate - 1< 0)
                throw new Exception("Coordinates are outside the plateau boundaries");
            this.Rover.YCoordinate = this.Rover.YCoordinate - 1;
          
        }
    }
}
