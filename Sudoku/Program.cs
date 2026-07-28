using Sudoku;

SudokuVue[] vue =
[
    new SudokuVue4x4(new SudokuModel4x4()),
    //new SudokuVue4x4(getTest4x4()),
    new SudokuVue9x9(getTest9x9()),
    new SudokuVueSamourail(getTestSamourail())
];
Console.Write("""
    1. sudoku 4x4
    2. sudoku 9x9
    3. sudoku Samourail
    choix : 
    """);
int choix = int.Parse(Console.ReadLine()) - 1;

Console.WriteLine(vue[choix].GetGrille());


SudokuModelSamourail getTestSamourail()
{
    SudokuModelSamourail model = new();
    model.AddValue(0, 0, '1');
    model.AddValue(0, 8, '2');
    model.AddValue(8, 8, '3');
    model.AddValue(8, 0, '4');

    model.AddValue(0, 12, '1');
    model.AddValue(0, 20, '2');
    model.AddValue(8, 20, '3');
    model.AddValue(8, 12, '4');

    model.AddValue(6, 6, '1');
    model.AddValue(6, 14, '2');
    model.AddValue(14, 14, '3');
    model.AddValue(14, 6, '4');

    model.AddValue(12, 0, '1');
    model.AddValue(12, 8, '2');
    model.AddValue(20, 8, '3');
    model.AddValue(20, 0, '4');

    model.AddValue(12, 12, '1');
    model.AddValue(12, 20, '2');
    model.AddValue(20, 20, '3');
    model.AddValue(20, 12, '4');
    return model;
}

SudokuModel9x9 getTest9x9()
{
    SudokuModel9x9 model = new();
    model.AddValue(0, 0, '2');
    model.AddValue(8, 8, '1');
    model.AddValue(0, 8, '3');
    model.AddValue(8, 2, '4');
    return model;
}


SudokuModel4x4 getTest4x4()
{
    SudokuModel4x4 model = new();
    model.AddValue(0, 0, '2');
    model.AddValue(3, 3, '1');
    return model;
}