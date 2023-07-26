public class RandomAgent : IAgent {
    public Player Player { get; init; }

    public Point Think(Grid grid) {
        var rng = new System.Random();
        return grid.EmptyCells[rng.Next(0, grid.EmptyCells.Count())];
    }
}
