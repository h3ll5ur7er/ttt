public class Point : IEquatable<Point> {
    public int X { get; set; }
    public int Y { get; set; }

    public bool Equals(Point? other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other) || X == other.X && Y == other.Y;
    }

    public override bool Equals(object? obj) => Equals(obj as Point);

    public override int GetHashCode() {
        unchecked
        {
            return (X * 397) ^ Y;
        }
    }
}
