using System;
using System.Collections.Generic;
using System.Text;

namespace Manipulator
{
    public class path
    {
        public List<MPoint> trajectory;
        public path()
            {
            trajectory = new List<MPoint>(100);
            }
    }
}
