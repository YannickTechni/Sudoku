using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal class SudokuModelSamourail : AbstractSudokuModel, ISudokuModel
    {

        public SudokuModelSamourail() : base()
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

        protected override SudokuCellule[,]? buildGrille()
        {
            SudokuCellule[,] grille = new SudokuCellule[21, 21];
            int[,] sudokuStart =
            {
                { 0, 0},
                { 0, 12 },
                { 6, 6 },
                { 12,0},
                { 12, 12 }
            };
            Zone[,] lgZones = new Zone[5, 9];
            Zone[,] colZones = new Zone[5, 9];
            Zone[,] sqZones = new Zone[5, 9];

            for (int sudo = 0; sudo < 5; sudo++)
            {
                for (int i = 0; i < 9; i++)
                {
                    lgZones[sudo, i] = new Zone($"sudoku_{sudo} ligne_{i}");
                    colZones[sudo, i] = new Zone($"sudoku_{sudo} colonne_{i}");
                    sqZones[sudo, i] = new Zone($"sudoku_{sudo} carre_{i}");
                }
            }

            for (int sudo = 0; sudo < 5; sudo++)
            {
                for (int line = 0; line < 9; line++)
                {
                    for (int col = 0; col < 9; col++)
                    {
                        int lt = line + sudokuStart[sudo, 0];
                        int ct = col + sudokuStart[sudo, 1];
                        if (grille[lt, ct] == null)
                        {
                            grille[lt, ct] = new SudokuCellule();
                            grille[lt, ct].AddZone(sqZones[sudo, line / 9 * 9 + col / 9]);
                        }
                        grille[lt, ct].AddZone(lgZones[sudo, line]);
                        grille[lt, ct].AddZone(colZones[sudo, col]);

                    }
                }
            }
            return grille;
        }
    }
}

