public class Cell {
    public CellState Value { get; set; }
    public static implicit operator CellState(Cell cell) {
        return cell.Value;
    }
    public static implicit operator Cell(CellState cell) {
        return new Cell { Value = cell };
    }
    public void Print() {
        Value.Print();
    }
}
