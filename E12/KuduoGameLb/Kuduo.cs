using System;

namespace KuduoGameLb
{
    public class Kuduo
    {
        private readonly int[,] _matrix;
        public int this[int row, int col]
        {
            get
            {
                if (row < 0 || row > _matrix.GetLength(0) - 1)
                    return -1;
                if (col < 0 || col > _matrix.GetLength(1) - 1)
                    return -1;
                return _matrix[col, row];
            }
            set
            {
                if (value < 0 || value > _matrix.GetLength(0) - 1)
                    return;
                if (value < 0 || value > _matrix.GetLength(1) - 1)
                    return;
                _matrix[col, row] = value;
            }
        }
        public Kuduo(int[,] matrix)
        {
            _matrix = matrix;
        }
    }
}
