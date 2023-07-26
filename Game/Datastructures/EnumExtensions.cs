using static CellState;

public static class EnumExtensions {
    public static CellState ToCellState(this Player player) {
        switch (player) {
            case Player.X:
                return CellState.X;
            case Player.O:
                return CellState.O;
            default:
                return CellState.Empty;
        }
    }
    public static Player Toggle(this Player player) {
        switch (player) {
            case Player.X:
                return Player.O;
            case Player.O:
                return Player.X;
            default:
                return (Player)(-1);
        }
    }
    public static void Print(this CellState cell) {
        switch (cell) {
            case Empty:
                Console.Write(" ");
                break;
            case X:
                Console.Write("X");
                break;
            case O:
                Console.Write("O");
                break;
        }
    }
}
