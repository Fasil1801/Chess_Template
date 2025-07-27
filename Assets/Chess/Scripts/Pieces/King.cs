
public class King : ChessPiece
{
    public override void ShowLeagalMoves()
    {
        int[] dRows = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] dCols = { -1, 0, 1, -1, 1, -1, 0, 1 };

        for (int i = 0; i < 8; i++)
        {
            int newRow = row + dRows[i];
            int newCol = col + dCols[i];

            if (IsValid(newRow, newCol))
            {
                ChessBoardPlacementHandler.Instance.Highlight(newRow,newCol);
            }
        }
    }
}
