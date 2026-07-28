using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal class SudokuModelSamourail : SudokuModel
    {
        private char[,] values = new char[21, 21];

        public SudokuModelSamourail()
        {
            for (int row = 0; row < values.GetLength(0); row++)
            {
                for (int col = 0; col < values.GetLength(1); col++)
                {
                    values[row, col] = SudokuModel.VIDE;
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

        internal bool isValid(int row, int col)
        {
            return row >= 0 && row < 21 && col >= 0 && col < 21
                && (row >= 6 || col < 9 || col > 11)
                && (row < 9 || row > 11 || col >=6 && col < 15)
                && (row < 15  || col < 9 || col > 11);
        }
    }
}

