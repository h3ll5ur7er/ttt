public class HumanAgent : IAgent {
    public Player Player { get; init; }

    public Point Think(Grid grid) {
        var ck = Console.ReadKey(true);
        var value = ck.KeyChar-'0';
        if (value < 1 || value > 9) {
            Console.WriteLine("Invalid input");
            return Think(grid);
        } 
        Console.WriteLine(value);
        return new Point{X=(value-1)%3, Y=2-((value-1)/3)};
    }
}
