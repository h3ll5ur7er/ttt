using static CellState;
public static class Program {
    public static void Main() {
        var game = new Game();
        game.Print();
        while (game.Winner == Empty) {
            game.Step();
            game.Print();
        }
        Console.WriteLine(game.Winner == Draw ? "Draw" : $"{game.Winner} wins");
    }
}