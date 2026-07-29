using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal interface ISudokuModel
    {
        static char VIDE = (char)0;

        int NbLigne { get; }
        int NbColonne { get; }

        char GetValue(int row, int column);

        void AddValue(int row, int column, char value);
        bool IsValid(int row, int column);
    }
}
