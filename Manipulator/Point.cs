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
    }
}
