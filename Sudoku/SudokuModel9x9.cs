using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal class SudokuModel9x9 : AbstractSudokuModel, ISudokuModel
    {
  
        public SudokuModel9x9():base(new char[9, 9])
        {
          }

        public int NbLigne => 9;

        public int NbColonne => 9;

          public override bool IsValid(int row, int column)
        {
            return row >= 0 && row < 9 && column >= 0 && column < 9;
        }

        public override bool IsValueValid(char value)
        {
            return value == ISudokuModel.VIDE || value >= '1' && value <= '9';
        }
    }
}
