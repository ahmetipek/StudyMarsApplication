using StudyMarsApplication.Models;
using StudyMarsApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMarsApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            var commandList = new List<String> { "L", "R", "M" };
            Rover FirstRover = new Rover(1, 2, "N", "LMLMLMLMM");
            Rover SecondRover = new Rover(3, 3, "E", "MMRMMRMRRM");
            int SideLength = 5;
            List<Rover> roverList = new List<Rover>();
            roverList.Add(FirstRover);
            roverList.Add(SecondRover);
            var directionDefinitionList = DirectionDefinition.DirectionDefinitionList;

            foreach (var rover in roverList)
            {
                foreach (var command in rover.CommandList)
                {
                    var directionList = directionDefinitionList.Where(x => x.FromDirection == rover.Direction).ToList();
                    if (directionList == null || !directionList.Any())
                    {
                        throw new Exception("Direction information not found");
                    }
                    if (command != 'M')
                    {
                        var direction = directionList.FirstOrDefault(x => x.TurnValue == command.ToString()).ToDirection;
                        rover.Direction = direction;
                    }
                    else
                    {
                        if (rover.Direction == "N")
                        {
                            IRoverCalculator northDirection = new NorthDirection(rover, SideLength);
                            northDirection.Calculate();
                        }
                        if (rover.Direction == "S")
                        {
                            IRoverCalculator northDirection = new SouthDirection(rover, SideLength);
                            northDirection.Calculate();
                        }
                        if (rover.Direction == "E")
                        {
                            IRoverCalculator northDirection = new EastDirection(rover, SideLength);
                            northDirection.Calculate();
                        }
                        if (rover.Direction == "W")
                        {
                            IRoverCalculator northDirection = new WestDirection(rover, SideLength);
                            northDirection.Calculate();
                        }

                    }

                }
                Console.WriteLine(String.Format("{0},{1} {2}", rover.XCoordinate, rover.YCoordinate, rover.Direction));
            }
            Console.ReadKey();

        }
    }
}
