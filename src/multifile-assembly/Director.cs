using System;

namespace Navigation
{
    public class Director
    {
        public int _direction = 0;

        public string GetDirection()
        {
            if (_direction == 0)
            {
                return "North";
            }
            else if (_direction == 1)
            {
                return "East";
            }
            else if (_direction == 2)
            {
                return "South";
            }
            else if (_direction == 3)
            {
                return "West";
            }

            throw new InvalidOperationException("Invalid state");
        }

        public void TurnRight()
        {
            _direction = (_direction + 1) % 4;
        }

        public void TurnLeft()
        {
            _direction = (_direction + 3) % 4;
        }
    }
}
