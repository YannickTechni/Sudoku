using Sudoku;
using System.Text.RegularExpressions;

internal class SudokuControler
{
    public ISudokuVue Vue { get; internal set; }
    public ISudokuModel Model { get; internal set; }

    internal void Start()
    {
        Regex regex = new Regex(@"(?'quitter'[Qq])|(?'line'\d+)\.(?'column'\d+)(\.(?'value'\S))?");

        Console.WriteLine(Vue.GetGrille());
        Console.Write("Entrez [ligne].[colonne].valeur : ");
        Match match = regex.Match(Console.ReadLine());
        while (!match.Groups["quitter"].Success)
        {
            if (match.Groups["value"].Success)
            {
                Model.AddValue(
                    int.Parse(match.Groups["line"].Value)-1,
                    int.Parse(match.Groups["column"].Value)-1,
                     match.Groups["value"].Value[0]);
            }
            else
            {
                Model.AddValue(
                    int.Parse(match.Groups["line"].Value)-1,
                    int.Parse(match.Groups["column"].Value)-1,
                    ISudokuModel.VIDE);
            }
            Console.WriteLine(Vue.GetGrille());
            Console.Write("Entrez [ligne].[colonne].[valeur] : ");
            match = regex.Match(Console.ReadLine());
        }
        ;
    }
}