using System;
using System.Globalization;

Exception? exception = null;

Tile[,] board = null!;
(int Row, int Column)? firstSelection = null;
(int Row, int Column)? secondSelection = null;
(int Row, int Column) selection = (0, 0);
bool closeRequested = false;
bool pendingConfirmation = false;

try
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.CursorVisible = false;
    Console.Clear();

    while (!closeRequested)
    {
        selection = (0, 0);
        Console.Clear();
        RandomizeBoard();
        EnsureConsoleSize();

        while ((!closeRequested && !AllTilesVisible()) || pendingConfirmation)
        {
            EnsureConsoleSize();
            if (!closeRequested)
            {
                Render();
                GetInput();
            }
        }

        if (!closeRequested)
        {
            selection = (-1, -1);
            Render();
            Console.WriteLine();
            Console.WriteLine(" You Win!");
            Console.WriteLine(" Play again [enter] or exit [escape]?");

            while (!closeRequested)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Enter) break;
                if (key == ConsoleKey.Escape)
                {
                    closeRequested = true;
                    break;
                }
            }
        }
    }
}
catch (Exception e)
{
    exception = e;
    throw;
}
finally
{
    Console.ResetColor();
    Console.CursorVisible = true;
    Console.Clear();
    Console.WriteLine(exception?.ToString() ?? "Memory was closed.");
}

void RandomizeBoard()
{
    board = new Tile[5, 10];

    int value = 1;
    for (int i = 0; i < board.GetLength(0); i++)
    {
        for (int j = 0; j < board.GetLength(1); j++)
        {
            board[i, j] = new Tile { Value = value };
            if ((i * board.GetLength(1) + j) % 2 == 1)
                value++;
        }
    }

    Random rng = new Random();
    int total = board.GetLength(0) * board.GetLength(1);

    for (int i = total - 1; i > 0; i--)
    {
        int j = rng.Next(i + 1);

        var a = (i / board.GetLength(1), i % board.GetLength(1));
        var b = (j / board.GetLength(1), j % board.GetLength(1));

        (board[a.Item1, a.Item2], board[b.Item1, b.Item2]) =
        (board[b.Item1, b.Item2], board[a.Item1, a.Item2]);
    }
}

void EnsureConsoleSize()
{
    int minWidth = board.GetLength(1) * 3 + 4;
    int minHeight = board.GetLength(0) * 2 + 13;

    while (!closeRequested &&
          (Console.WindowWidth < minWidth || Console.WindowHeight < minHeight))
    {
        Console.Clear();
        Console.WriteLine("Increase console size and press [enter]...");
        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.Escape)
            closeRequested = true;
    }
    Console.Clear();
}

void Render()
{
    Console.CursorVisible = false;
    Console.SetCursorPosition(0, 0);
    Console.Clear();

    Console.WriteLine();
    Console.WriteLine(" Memory");
    Console.WriteLine();

    for (int i = 0; i < board.GetLength(0); i++)
    {
        Console.Write("  ");
        for (int j = 0; j < board.GetLength(1); j++)
        {
            Console.Write(' ');

            if (firstSelection is not null && secondSelection is not null &&
                (firstSelection == (i, j) || secondSelection == (i, j)))
            {
                var a = firstSelection.Value;
                var b = secondSelection.Value;
                Console.BackgroundColor =
                    board[a.Row, a.Column].Value == board[b.Row, b.Column].Value
                    ? ConsoleColor.DarkGreen
                    : ConsoleColor.DarkRed;
            }
            else if (firstSelection == (i, j) || secondSelection == (i, j))
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            else if (selection == (i, j))
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            else if (board[i, j].Visible)
                Console.BackgroundColor = ConsoleColor.DarkGray;
            else
                Console.BackgroundColor = ConsoleColor.White;

            if (board[i, j].Visible)
            {
                Console.Write(board[i, j].Value.ToString("D2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.Write("  ");
            }

            Console.BackgroundColor = ConsoleColor.Black;
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    Console.WriteLine(" Controls...");
    Console.WriteLine(" - arrow keys: change selection");
    Console.WriteLine(" - enter: confirm");
    Console.WriteLine(" - escape: exit");
}

void GetInput()
{
    var key = Console.ReadKey(true).Key;

    if (pendingConfirmation)
    {
        if (key == ConsoleKey.Enter)
        {
            pendingConfirmation = false;
            var a = board[firstSelection!.Value.Row, firstSelection.Value.Column];
            var b = board[secondSelection!.Value.Row, secondSelection.Value.Column];

            if (a.Value != b.Value)
            {
                a.Visible = false;
                b.Visible = false;
            }

            firstSelection = null;
            secondSelection = null;
        }
        else if (key == ConsoleKey.Escape)
            closeRequested = true;

        return;
    }

    switch (key)
    {
        case ConsoleKey.RightArrow:
            selection = (selection.Row, (selection.Column + 1) % board.GetLength(1));
            break;
        case ConsoleKey.LeftArrow:
            selection = (selection.Row,
                (selection.Column - 1 + board.GetLength(1)) % board.GetLength(1));
            break;
        case ConsoleKey.UpArrow:
            selection = ((selection.Row - 1 + board.GetLength(0)) % board.GetLength(0), selection.Column);
            break;
        case ConsoleKey.DownArrow:
            selection = ((selection.Row + 1) % board.GetLength(0), selection.Column);
            break;
        case ConsoleKey.Enter:
            if (!board[selection.Row, selection.Column].Visible)
            {
                board[selection.Row, selection.Column].Visible = true;
                if (firstSelection is null)
                    firstSelection = selection;
                else
                {
                    secondSelection = selection;
                    pendingConfirmation = true;
                }
            }
            break;
        case ConsoleKey.Escape:
            closeRequested = true;
            break;
    }
}

bool AllTilesVisible()
{
    for (int i = 0; i < board.GetLength(0); i++)
        for (int j = 0; j < board.GetLength(1); j++)
            if (!board[i, j].Visible)
                return false;

    return true;
}

class Tile
{
    public int Value { get; set; }
    public bool Visible { get; set; }
}
