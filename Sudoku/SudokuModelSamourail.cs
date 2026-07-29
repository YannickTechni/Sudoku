using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal class SudokuModelSamourail : AbstractSudokuModel, ISudokuModel
    {

        public SudokuModelSamourail() : base(new char[21, 21])
        {
        }

        public int NbLigne => 21;

        public int NbColonne => 21;

        public override bool IsValid(int row, int col)
        {
            return row >= 0 && row < 21 && col >= 0 && col < 21
                && (row >= 6 || col < 9 || col > 11)
                && (row < 9 || row > 11 || col >= 6 && col < 15)
                && (row < 15 || col < 9 || col > 11); ;
        }

        public override bool IsValueValid(char value)
        {
            return value >= '1' && value <= '9' || value == ISudokuModel.VIDE;
        }

    }
}

