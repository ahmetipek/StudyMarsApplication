using StudyMarsApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMarsApplication.Services
{
    public class EastDirection :Direction, IRoverCalculator
    {
        public EastDirection(Rover Rover, int SideLength):base(Rover,SideLength)
        {
        }
        public void Calculate()
        {
            if (this.Rover.XCoordinate - 1 < 0)
                throw new Exception("Coordinates are outside the plateau boundaries");
            this.Rover.XCoordinate = this.Rover.XCoordinate-1;
           
        }
    }
}
