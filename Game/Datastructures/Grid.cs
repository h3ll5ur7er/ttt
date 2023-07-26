using static CellState;

public class Grid {
    private Cell[] _cells = {
        Empty, Empty, Empty,
        Empty, Empty, Empty,
        Empty, Empty, Empty
    };

    public Cell this[int index] {
        get { return _cells[index]; }
        set { _cells[index] = value; }
    }

    public Cell this[int x, int y] {
        get { return _cells[x + y * 3]; }
        set { _cells[x + y * 3] = value; }
    }

    public Cell this[Point p] {
        get { return _cells[p.X + p.Y * 3]; }
        set { _cells[p.X + p.Y * 3] = value; }
    }

    public Slot[] Rows {
        get {
            return new[] {
                new Slot(this[0, 0], this[1, 0], this[2, 0]),
                new Slot(this[0, 1], this[1, 1], this[2, 1]),
                new Slot(this[0, 2], this[1, 2], this[2, 2])
            };
        }
    }

    public Slot[] Columns {
        get {
            return new[] {
                new Slot( this[0, 0], this[0, 1], this[0, 2] ),
                new Slot( this[1, 0], this[1, 1], this[1, 2] ),
                new Slot( this[2, 0], this[2, 1], this[2, 2] )
            };
        }
    }

    public Slot[] Diagonals {
        get {
            return new[] {
                new Slot(this[0, 0], this[1, 1], this[2, 2]),
                new Slot(this[2, 0], this[1, 1], this[0, 2])
            };
        }
    }

    public CellState Winner {
        get {
            foreach (var row in Rows) {
                var (c0, c1, c2) = row;
                if (c0.Value != Empty && c0.Value == c1.Value && c0.Value == c2.Value) {
                    return c0;
                }
            }
            foreach (var column in Columns) {
                var (c0, c1, c2) = column;
                if (c0.Value != Empty && c0.Value == c1.Value && c0.Value == c2.Value) {
                    return c0;
                }
            }
            foreach (var diagonal in Diagonals) {
                var (c0, c1, c2) = diagonal;
                if (c0.Value != Empty && c0.Value == c1.Value && c0.Value == c2.Value) {
                    return c0;
                }
            }
            if (EmptyCells.Length == 0) {
                return Draw;
            }
            return Empty;
        }
    }

    public Point[] EmptyCells {
        get {
            var points = new List<Point>();
            for (var i = 0; i < _cells.Length; i++) {
                if (_cells[i] == Empty) {
                    points.Add(new Point { X = i % 3, Y = i / 3 });
                }
            }
            return points.ToArray();
        }
    }
    
    public void Print() {
        Console.WriteLine();
        for (var y = 0; y < 3; y++) {
            for (var x = 0; x < 3; x++) {
                this[x, y].Print();
                if (x < 2) {
                    Console.Write("|");
                }
            }
            Console.WriteLine();
            if (y < 2) {
                Console.WriteLine("-----");
            }
        }
        Console.WriteLine();
    }
}
