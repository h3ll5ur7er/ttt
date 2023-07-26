public interface IAgent {
    Player Player { get; init; }
    Point Think(Grid grid);
}
