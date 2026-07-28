using Sudoku;
using System.Text.RegularExpressions;

internal class SudokuControler
{
    public ISudokuVue Vue { get; internal set; }
    public ISudokuModel Model { get; internal set; }

    internal void Start()
    {
        Regex regex = new Regex(@"(?'quitter'[Qq])|(?'line'\d+)\.(?'column'\d+)(\.(?'value'\S))?");
    
        Match match = regex.Match("1.1.2");
        Console.WriteLine(match.Success);
        Console.WriteLine("group 0 :"+match.Groups[0].Value);
        Console.WriteLine("group 1 :" + match.Groups["quitter"].Value);
        Console.WriteLine("group 2 :" + match.Groups["line"].Value);
        Console.WriteLine("group 3 :" + match.Groups["column"].Value);
        Console.WriteLine("group 4 :" + match.Groups["value"].Value);

        match = regex.Match("q");
        Console.WriteLine(match.Success);
        Console.WriteLine("group 0 :" + match.Groups[0].Value);
        Console.WriteLine("group 1 :" + match.Groups[1].Value);
        Console.WriteLine("group 2 :" + match.Groups[2].Value);
        Console.WriteLine("group 3 :" + match.Groups[3].Value);
        Console.WriteLine("group 4 :" + match.Groups[4].Value);

        match = regex.Match("toto");
        Console.WriteLine(match.Success);
        Console.WriteLine("group 0 :" + match.Groups[0].Value);
        Console.WriteLine("group 1 :" + match.Groups[1].Value);
        Console.WriteLine("group 2 :" + match.Groups[2].Value);
        Console.WriteLine("group 3 :" + match.Groups[3].Value);
        Console.WriteLine("group 4 :" + match.Groups[4].Value);

    }
}