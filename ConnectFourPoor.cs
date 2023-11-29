// A method that checks if a player has won by forming a diagonal line of four
public bool HasDiagonalWin(int player)
{
    for (int i = 0; i < board.GetLength(0) - 3; i++)
    {
        for (int j = 0; j < board.GetLength(1) - 3; j++)
        {
            if (board[i, j] == player && board[i + 1, j + 1] == player && board[i + 2, j + 2] == player && board[i + 3, j + 3] == player)
            {
                return true;
            }
        }
    }
    for (int i = 0; i < board.GetLength(0) - 3; i++)
    {
        for (int j = 3; j < board.GetLength(1); j++)
        {
            if (board[i, j] == player && board[i + 1, j - 1] == player && board[i + 2, j - 2] == player && board[i + 3, j - 3] == player)
            {
                return true;
            }
        }
    }
    return false;
}

// A method that checks if a player has won by forming any line of four
public bool HasWin(int player)
{
    return HasHorizontalWin(player) || HasVerticalWin(player) || HasDiagonalWin(player);
}

// A method that inserts a disc into a column
public bool Insert(int column, int player)
{
    if (column < 0 || column >= board.GetLength(1))
    {
        return false;
    }
    for (int i = board.GetLength(0) - 1; i >= 0; i--)
    {
        if (board[i, column] == 0)
        {
            board[i, column] = player;
            return true;
        }
    }
    return false;
}


