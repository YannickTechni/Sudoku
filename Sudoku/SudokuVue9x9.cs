using Sudoku;
using System.Reflection;
using System.Text;

internal class SudokuVue9x9:ISudokuVue
{
    private String format;
    private SudokuModel9x9 model;

    public SudokuVue9x9(SudokuModel9x9 sudokuModel9x9)
    {
        this.model = sudokuModel9x9;
    }

    public string GetGrille()
    {
        Object[] param = new Object[9*9];
        int pos = 0;
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char val = model.GetValue(i, j);
                param[pos++] = val == ISudokuModel.VIDE ? '.' : val;
            }
        }
        return String.Format(GetFormat(GetGrilleVide()), param);
    }


    public string GetGrilleVide()
    {
        return """
            +-------+-------+-------+
            | . . . | . . . | . . . |
            | . . . | . . . | . . . |
            | . . . | . . . | . . . |
            +-------+-------+-------+
            | . . . | . . . | . . . |
            | . . . | . . . | . . . |
            | . . . | . . . | . . . |
            +-------+-------+-------+
            | . . . | . . . | . . . |
            | . . . | . . . | . . . |
            | . . . | . . . | . . . |
            +-------+-------+-------+
            """;
    }
    private string GetFormat(String depart)
    {
        if (this.format == null)
        {

            StringBuilder builder = new StringBuilder();
            int start = 0;
            int end = depart.IndexOf('.', start);
            int cpt = 0;
            while (end > 0)
            {
                builder.Append(depart.Substring(start, end - start))
                    .Append('{')
                    .Append(cpt++)
                    .Append('}');
                start = end + 1;
                end = depart.IndexOf('.', start);
            }
            format = builder.Append(depart.Substring(start)).ToString();
        }
        return format;
    }

}