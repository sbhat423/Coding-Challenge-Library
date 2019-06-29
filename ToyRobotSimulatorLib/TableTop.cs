using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulatorLib
{
    public class TableTop
    {
        public int MinimumRowIndex { get; private set; }
        public int MaximumRowIndex { get; private set; }
        public int MinimumColumnIndex { get; private set; }
        public int MaximumColumnIndex { get; private set; }

        public TableTop()
        {
            MinimumRowIndex = 0;
            MaximumRowIndex = 4;
            MinimumColumnIndex = 0;
            MaximumColumnIndex = 4;
        }
    }
}
