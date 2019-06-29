using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulatorLib
{
    class RobotMovementController
    {
        RobotPosition robotPosition;

        public RobotMovementController(RobotPosition position)
        {
            robotPosition = position;
        }

        public void TurnLeft()
        {
            int xCordinate = robotPosition.XCordinate;
            int yCordinate = robotPosition.YCordinate;
            eDirection direction = robotPosition.Direction;

            switch(robotPosition.Direction)
            {
                case eDirection.North:
                    direction = eDirection.West;
                    break;

                case eDirection.East:
                    direction = eDirection.North;
                    break;

                case eDirection.West:
                    direction = eDirection.South;
                    break;

                case eDirection.South:
                    direction = eDirection.East;
                    break;
            }

            robotPosition.UpdatePosition(xCordinate, yCordinate, direction);
        }

        public void TurnRight()
        {
            int xCordinate = robotPosition.XCordinate;
            int yCordinate = robotPosition.YCordinate;
            eDirection direction = robotPosition.Direction;

            switch (robotPosition.Direction)
            {
                case eDirection.North:
                    direction = eDirection.East;
                    break;

                case eDirection.East:
                    direction = eDirection.South;
                    break;

                case eDirection.West:
                    direction = eDirection.North;
                    break;

                case eDirection.South:
                    direction = eDirection.West;
                    break;
            }

            robotPosition.UpdatePosition(xCordinate, yCordinate, direction);
        }

        public void Place(int xCordinate, int yCordinate, eDirection direction)
        {
            robotPosition.UpdatePosition(xCordinate, yCordinate, direction);
        }

        public void Move()
        {
            int xCoordinate = robotPosition.XCordinate;
            int yCoordinate = robotPosition.YCordinate;
            eDirection direction = robotPosition.Direction;

            switch(direction)
            {
                case eDirection.North:
                    if (yCoordinate == 4)
                        break;
                    else
                        robotPosition.UpdatePosition(xCoordinate, (yCoordinate + 1), direction);
                    break;

                case eDirection.East:
                    if (xCoordinate == 4)
                        break;
                    else
                        robotPosition.UpdatePosition((xCoordinate+1), yCoordinate, direction);
                    break;

                case eDirection.West:
                    if (xCoordinate == 0)
                        break;
                    else
                        robotPosition.UpdatePosition((xCoordinate - 1), yCoordinate, direction);
                    break;

                case eDirection.South:
                    if (yCoordinate == 0)
                        break;
                    else
                        robotPosition.UpdatePosition(xCoordinate, (yCoordinate - 1), direction);
                    break;
            }
        }
    }
}
