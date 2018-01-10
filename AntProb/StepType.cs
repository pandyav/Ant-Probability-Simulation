using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntProb
{
    public class StepType
    {
        public Node foodCell;
        public int steps = 0;

        public StepType(Node n, int i)
        {
            foodCell = n;
            steps = i;
        }
    }
}
