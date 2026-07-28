using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal class SudokuModel9x9 : ISudokuModel
    {
        private char[,] values = new char[9, 9];

        public SudokuModel9x9()
        {
            for (int row = 0; row < values.GetLength(0); row++)
            {
                for (int col = 0; col < values.GetLength(1); col++)
                {
                    values[row, col] = ISudokuModel.VIDE;
                }
            }
        }
        public void AddValue(int row, int column, char value)
        {
            values[row, column] = value;
        }

        public char GetValue(int row, int column)
        {
            return values[row, column];
        }
    }
}
