namespace Navigation
{
    public class DirectionProvider
    {
        private string[] _directions =
            new string[]
            {
                "North",
                "East",
                "South",
                "West"
            };

        public string GetDirection(int direction)
        {
            if (direction < 4 && direction >= 0)
            {
                return _directions[direction];
            }

            return "Invalid direction";
        }
    }
}
