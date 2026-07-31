using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal class SudokuModel4x4 : AbstractSudokuModel, ISudokuModel
    {

        public SudokuModel4x4() : base()
        {
        }

        // public int NbLigne { get; } = 4;
        public int NbLigne
        {
            get
            {
                return 4;
            }
        }

        public int NbColonne
        {
            get
            {
                return 4;
            }
        }


        public override bool IsValid(int row, int column)
        {
            return row >= 0 && row < 4 && column >= 0 && column < 4;
        }

        public override bool IsValueValid(char value)
        {
            return value == ISudokuModel.VIDE || value >= '1' && value <= '4';
        }

        protected override SudokuCellule[,]? buildGrille()
        {
            SudokuCellule[,]? grille = new SudokuCellule[4,4];

            return grille ;
        }
    }
}
