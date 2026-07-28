using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal class SudokuModel4x4 : ISudokuModel
    {
        private char[,] values = new char[4, 4];

        public SudokuModel4x4()
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
            if (row >= 0 && row < 4 && column >= 0 && column < 4)
                if (value == ISudokuModel.VIDE || value >= '1' && value <= '4')
                    values[row, column] = value;
        }

        public char GetValue(int row, int column)
        {
            if (row >= 0 && row < 4 && column >= 0 && column < 4)
                return values[row, column];
            else
                return ISudokuModel.VIDE;
        }
    }
}
