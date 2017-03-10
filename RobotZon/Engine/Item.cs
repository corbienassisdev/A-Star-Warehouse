namespace RobotZon.Engine
{
    public class Item
    {
        public string Name { get; set; }
        public Position Position { get; set; }
        public ItemOrientation Orientation { get; set; }

        public Item(string name, Position position, ItemOrientation orientation)
        {
            Name = name;
            Position = position;
            Orientation = orientation;
        }
    }
}
