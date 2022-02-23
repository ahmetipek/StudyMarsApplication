using StudyMarsApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMarsApplication.Services
{
    public class NorthDirection :Direction, IRoverCalculator
    {
        public NorthDirection(Rover Rover, int SideLength)
            : base(Rover,SideLength)
        {
        }
        public void Calculate()
        {
            if (this.Rover.YCoordinate + 1 > this.SideLength)
                throw new Exception("Coordinates are outside the plateau boundaries");
            this.Rover.YCoordinate = this.Rover.YCoordinate + 1;
           
        }
    }
}
