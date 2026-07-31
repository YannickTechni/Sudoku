using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal abstract class AbstractSudokuModel
    {
        private SudokuCellule[,] _values;

        public AbstractSudokuModel()
        {
            _values = buildGrille();
        }

        protected abstract SudokuCellule[,]? buildGrille();

        public void AddValue(int row, int column, char value)
        {
            if (this.IsValid(row, column))
                if (IsValueValid(value))
                    _values[row, column].Value = value;
        }

        public abstract bool IsValueValid(char value);

        public char GetValue(int row, int column)
        {
            if (this.IsValid(row, column))
                return _values[row, column].Value;
            else
                return ISudokuModel.VIDE;
        }

        public void Lock()
        {
            for (int i = 0; i < _values.GetLength(0); i++)
            {
                for (int j = 0; j < _values.GetLength(1); j++)
                {
                    _values[i, j].Lock = true;
                }
            }
        }

        public abstract bool IsValid(int row, int column);
    }
        
}
