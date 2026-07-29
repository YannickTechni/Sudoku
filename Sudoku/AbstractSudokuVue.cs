using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal abstract class AbstractSudokuVue
    {
        private ISudokuModel model;
        private string format;
        private int _nbCase;

        public AbstractSudokuVue(ISudokuModel sudokuModel)
        {
            this.model = sudokuModel;
            format = GetFormat(GetGrilleVide());
        }

        public string GetGrille()
        {
            Object[] param = new Object[_nbCase];
            int pos = 0;

            for (int i = 0; i < model.NbLigne; i++)
            {
                for (int j = 0; j < model.NbColonne; j++)
                {
                    if (model.IsValid(i, j))
                    {
                        char val = model.GetValue(i, j);
                        param[pos++] = val == ISudokuModel.VIDE ? '.' : val;
                    }

                }
            }
            return String.Format(format, param);
        }
        private string GetFormat(String depart)
        {
            if (this.format == null)
            {

                StringBuilder builder = new StringBuilder();
                int start = 0;
                int end = depart.IndexOf('.', start);
                int cpt = 0;
                _nbCase = 0;
                while (end > 0)
                {
                    builder.Append(depart.Substring(start, end - start))
                        .Append('{')
                        .Append(cpt++)
                        .Append('}');
                    start = end + 1;
                    end = depart.IndexOf('.', start);
                    _nbCase++;
                }
                format = builder.Append(depart.Substring(start)).ToString();
            }
            return format;
        }

        public abstract string GetGrilleVide();
    }
}
