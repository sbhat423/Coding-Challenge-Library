using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulatorLib
{
    public class Position
    {
        public int XCordinate { get; protected set; }

        public int YCordinate { get; protected set; }

        public eDirection Direction { get; protected set; }
    }
}
