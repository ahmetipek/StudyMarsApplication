using StudyMarsApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMarsApplication.Services
{
    public abstract class Direction
    {
        public  Rover Rover { get; set; }
        public int SideLength { get; set; }
        public Direction(Rover Rover ,int SideLength)
        {
            this.SideLength = SideLength;
            this.Rover = Rover;
        }
    }
}
