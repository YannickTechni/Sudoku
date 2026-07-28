using Sudoku;
using System.Text;

internal class SudokuVue4x4 : ISudokuVue
{
    private SudokuModel4x4 model;
    private string? format = null;

    public SudokuVue4x4(SudokuModel4x4 model)
    {
        this.model = model;
    }

    public string GetGrille()
    {
        Object[] param = new Object[16];
        int pos = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
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
            +-----+-----+
            | . . | . . |
            | . . | . . |
            +-----+-----+
            | . . | . . |
            | . . | . . |
            +-----+-----+
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