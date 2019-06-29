using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulatorLib
{
    public class RobotPosition : Position
    {
        public bool IsPlaced { get; private set; }

        public RobotPosition()
        {
            DefaultPosition();
            IsPlaced = false;
        }

        public void UpdatePosition(int xCordinate, int yCordinate, eDirection direction)
        {
            if (IsPositionValid(xCordinate, yCordinate, direction))
            {
                SetPosition(xCordinate, yCordinate, direction);
                IsPlaced = true;
            }
        }

        private void DefaultPosition()
        {
            XCordinate = -1;
            YCordinate = -1;
            Direction = eDirection.None;
        }

        private void SetPosition(int xCordinate, int yCordinate, eDirection direction)
        {
            this.XCordinate = xCordinate;
            this.YCordinate = yCordinate;
            this.Direction = direction;
        }

        private bool IsPositionValid(int xCordinate, int yCordinate, eDirection direction)
        {
            bool bValidPosition = false;

            if (xCordinate < 0 || xCordinate > 4 ||
                yCordinate < 0 || yCordinate > 4 ||
                direction == eDirection.None)
            {
                bValidPosition = false;
            }
            else
            {
                bValidPosition = true;
            }

            return bValidPosition;
        }
    }
}
