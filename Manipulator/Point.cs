using System;

namespace Manipulator
{
    public class MPoint
    {
        private int _x, _y, _z;
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value; 
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public int Z
        {
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            }
        }

        public static MPoint Test(MPoint point)
        {
            if (point.X > 180) { point.X = 180; }
            if (point.Y > 180) { point.Y = 180; }
            if (point.Z > 180) { point.Z = 180; }
            return (point);
        }
        public void correct()
        {
            if (this.X > 180) { this.X = 180; }
            if (this.Y > 180) { this.Y = 180; }
            if (this.Z > 180) { this.Z = 180; }
        }
    }
}
