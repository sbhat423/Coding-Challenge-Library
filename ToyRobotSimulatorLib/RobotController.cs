using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulatorLib
{
    public class RobotController
    {
        Robot robot;

        public RobotController(Robot robot)
        {
            this.robot = robot;
        }

        public void ReadCommand(List<string> commandList)
        {
            foreach(string command in commandList)
            {
                string command1 = command.ToUpper().Trim();
                ProcessCommand(command1);
            }
        }

        private void ProcessCommand(string command)
        {
            if (command.Contains("PLACE"))
            {
                command = command.Replace(' ', ',');
            }

            string[] commandInputs = command.Split(',');
            string mainCommand = commandInputs[0];

            switch (mainCommand)
            {
                case "PLACE":
                    robot.Place(Int32.Parse(commandInputs[1]), Int32.Parse(commandInputs[2]),
                        (eDirection)Enum.Parse(typeof(eDirection), commandInputs[3], true));
                    break;

                case "MOVE":
                    robot.Move();
                    break;

                case "LEFT":
                    robot.TurnLeft();
                    break;

                case "RIGHT":
                    robot.TurnRight();
                    break;

                case "REPORT":
                    RobotPosition robotPosition = robot.GetReport();
                    if (robotPosition != null)
                        PrintReport(robotPosition);
                    break;

                default:
                    DisplayInvalidCommand();
                    break;
            }
        }

        private static void PrintReport(RobotPosition robotPosition)
        {
            //Output is currently being written to the console.
            //This method can be changed  to write output in the required format.
            Console.WriteLine("Output: {0},{1},{2}", robotPosition.XCordinate, robotPosition.YCordinate,
                                        Enum.GetName(typeof(eDirection), robotPosition.Direction).ToUpper());
        }

        private void DisplayInvalidCommand()
        {
            Console.WriteLine("Ignoring command. Invalid instruction.");
        }
    }
}
