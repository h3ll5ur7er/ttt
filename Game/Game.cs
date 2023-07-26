public class Game {
    private Grid _grid = new Grid();
    private IAgent agentX = new HumanAgent{Player = Player.X};
    private IAgent agentO = new RandomAgent{Player = Player.O};
    private IAgent? _currentPlayer = null;

    public CellState Winner {
        get { return _grid.Winner; }
    }

    public Game()
    {
        ToggleAgent();
    }
    public void Print() {
        _grid.Print();
    }
    void ToggleAgent() {
        _currentPlayer = _currentPlayer?.Player == Player.X ? agentO : agentX;
    }

    public void Step() {
        var rng = new System.Random();
        _grid[_currentPlayer?.Think(_grid)??throw new Exception()].Value = _currentPlayer.Player.ToCellState();
        ToggleAgent();
    }


}
