public class Slot : Tuple<Cell, Cell, Cell>
{
    public Slot(Cell item1, Cell item2, Cell item3) : base(item1, item2, item3)
    {
    }
    public static implicit operator Cell[](Slot slot)
    {
        return new[] { slot.Item1, slot.Item2, slot.Item3 };
    }
    public static implicit operator Slot(Cell[] cells)
    {
        return new Slot(cells[0], cells[1], cells[2]);
    }
}
