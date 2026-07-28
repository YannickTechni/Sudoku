using Sudoku;
using System.Reflection;
using System.Text;

internal class SudokuVueSamourail : SudokuVue
{
    private SudokuModelSamourail model;
    private string format;

    public SudokuVueSamourail(SudokuModelSamourail sudokuModelSamourail)
    {
        this.model = sudokuModelSamourail;
    }

    public string GetGrille()
    {
        Object[] param = new Object[21 * 21-4*3*6];
        int pos = 0;
        for (int i = 0; i < 21; i++)
        {
            for (int j = 0; j < 21; j++)
            {
                if (model.isValid(i, j))
                {
                    char val = model.GetValue(i, j);
                    param[pos++] = val == SudokuModel.VIDE ? '.' : val;
                }

            }
        }
        return String.Format(GetFormat(GetGrilleVide()), param);
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

    public string GetGrilleVide()
    {
        return """
            +-------+-------+-------+       +-------+-------+-------+
            | . . . | . . . | . . . |       | . . . | . . . | . . . |
            | . . . | . . . | . . . |       | . . . | . . . | . . . |
            | . . . | . . . | . . . |       | . . . | . . . | . . . |
            +-------+-------+-------+       +-------+-------+-------+
            | . . . | . . . | . . . |       | . . . | . . . | . . . |
            | . . . | . . . | . . . |       | . . . | . . . | . . . |
            | . . . | . . . | . . . |       | . . . | . . . | . . . |
            +-------+-------+-------+-------+-------+-------+-------+
            | . . . | . . . | . . . | . . . | . . . | . . . | . . . |
            | . . . | . . . | . . . | . . . | . . . | . . . | . . . |
            | . . . | . . . | . . . | . . . | . . . | . . . | . . . |
            +-------+-------+-------+-------+-------+-------+-------+
                            | . . . | . . . | . . . |
                            | . . . | . . . | . . . |
                            | . . . | . . . | . . . |
            +-------+-------+-------+-------+-------+-------+-------+
            | . . . | . . . | . . . | . . . | . . . | . . . | . . . |
            | . . . | . . . | . . . | . . . | . . . | . . . | . . . |
            | . . . | . . . | . . . | . . . | . . . | . . . | . . . |
            +-------+-------+-------+-------+-------+-------+-------+
            | . . . | . . . | . . . |       | . . . | . . . | . . . |
            | . . . | . . . | . . . |       | . . . | . . . | . . . |
            | . . . | . . . | . . . |       | . . . | . . . | . . . |
            +-------+-------+-------+       +-------+-------+-------+
            | . . . | . . . | . . . |       | . . . | . . . | . . . |
            | . . . | . . . | . . . |       | . . . | . . . | . . . |
            | . . . | . . . | . . . |       | . . . | . . . | . . . |
            +-------+-------+-------+       +-------+-------+-------+
            """;
    }
}