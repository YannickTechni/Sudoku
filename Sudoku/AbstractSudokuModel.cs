using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal abstract class AbstractSudokuModel
    {
        private char[,] _values;

        public AbstractSudokuModel(char[,] values)
        {
            _values = values;
            for (int row = 0; row < _values.GetLength(0); row++)
            {
                for (int col = 0; col < _values.GetLength(1); col++)
                {
                    _values[row, col] = ISudokuModel.VIDE;
                }
            }
        }
        public void AddValue(int row, int column, char value)
        {
            if (this.IsValid(row, column))
                if (IsValueValid(value))
                    _values[row, column] = value;
        }

        public abstract bool IsValueValid(char value);

        public char GetValue(int row, int column)
        {
            if (this.IsValid(row, column))
                return _values[row, column];
            else
                return ISudokuModel.VIDE;
        }

        public abstract bool IsValid(int row, int column);
    }
        
}
