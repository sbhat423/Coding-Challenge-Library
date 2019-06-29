using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulatorLib
{
    public class Robot
    {
        RobotPosition robotPosition;
        RobotMovementController movementController;

        public Robot()
        {
            robotPosition = new RobotPosition();
            movementController = new RobotMovementController(robotPosition);
        }

        public void Place(int xCoordinate, int yCoordinate, eDirection direction)
        {
            movementController.Place(xCoordinate, yCoordinate, direction);
        }

        public void Move()
        {
            movementController.Move();
        }

        public void TurnLeft()
        {
            movementController.TurnLeft();
        }

        public void TurnRight()
        {
            movementController.TurnRight();
        }

        public RobotPosition GetReport()
        {
            if (robotPosition.IsPlaced)
            {
                return robotPosition;
            }
            else

            {
                return null;
            }
        } 
    }
}
