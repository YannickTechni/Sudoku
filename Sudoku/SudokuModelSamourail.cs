using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal class SudokuModelSamourail : ISudokuModel
    {
        private char[,] values = new char[21, 21];

        public SudokuModelSamourail()
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
            if (isValid(row, column))
                if (value >= '1' && value <= '9' || value == ISudokuModel.VIDE)
                    values[row, column] = value;
        }

        public char GetValue(int row, int column)
        {
            if (isValid(row, column))
                return values[row, column];
            else
                return ISudokuModel.VIDE;
        }

        internal bool isValid(int row, int col)
        {
            return row >= 0 && row < 21 && col >= 0 && col < 21
                && (row >= 6 || col < 9 || col > 11)
                && (row < 9 || row > 11 || col >= 6 && col < 15)
                && (row < 15 || col < 9 || col > 11);
        }
    }
}

