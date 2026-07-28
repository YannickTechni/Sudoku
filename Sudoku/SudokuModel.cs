using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal interface SudokuModel
    {
        static char VIDE = (char)0;

        char GetValue(int row, int column);

        void AddValue(int row, int column, char value);
    }
}
