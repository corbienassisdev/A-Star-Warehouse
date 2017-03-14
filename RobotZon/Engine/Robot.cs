using System;
using System.Collections.Generic;

namespace RobotZon.Engine
{
    public class Robot
    {
        public string Name { get; set; }
        public Position Position { get; protected set; }
        public Queue<Position> Path { get; protected set; }

        public Robot(string name, Position position)
        {
            Name = name;
            Position = position;
            Path = new Queue<Position>();
        }

        public void Move(Position limit)
        {
            Position position = Path.Dequeue();
            if (position.x >= 0 && position.x < limit.x && position.y >= 0 && position.y < limit.y)
            {
                Position = position;
            }
        }

        public void GetPathTo(Position destination)
        {
            Position delta = destination - Position;
            Position absolute = new Position(Math.Abs(delta.x), Math.Abs(delta.y));
            int xs = absolute.x != 0 ? delta.x / absolute.x : 0;
            int ys = absolute.y != 0 ? delta.y / absolute.y : 0;
            int min = Math.Min(absolute.x, absolute.y);
            int max = Math.Max(absolute.x, absolute.y);

            for(int i = 1; i < max + 1; i++)
            {
                int direct = i;
                int transversal = min != 0 ? (int)Math.Ceiling((float)i / min) : 0;
                if (max == absolute.x)
                {
                    Path.Enqueue(new Position(Position.x + (direct * xs), Position.y + (transversal * ys)));
                }
                else if (max == absolute.y)
                {
                    Path.Enqueue(new Position(Position.x + (transversal * xs), Position.y + (direct * ys)));
                }
            }
        }
    }
}
