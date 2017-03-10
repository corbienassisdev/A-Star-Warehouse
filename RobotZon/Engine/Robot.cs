using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotZon.Engine
{
    public class Robot
    {
        public string Name { get; set; }
        public Position Position { get; set; }

        public Robot(string name, Position position)
        {
            Name = name;
            Position = position;
        }
    }
}
