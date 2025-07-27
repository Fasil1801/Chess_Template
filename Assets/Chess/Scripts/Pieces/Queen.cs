
public class Queen : ChessPiece
{
    public override void ShowLeagalMoves()
    {
        int[,] direction = new int[,]
         {
           {-1,0},{1,0}, {0,1},{0,-1},
           {-1,-1},{-1,1}, {1,-1},{1,1}
         };

        for (int i = 0; i < 4; i++)
        {
            int newRow = row + direction[i, 0];
            int newCol = col + direction[i, 1];
            while (IsValid(newRow, newCol))
            {
                var piece = ChessSelectionManager.instance.GetPiece(newRow, newCol);
                if (piece != null) break;

                ChessBoardPlacementHandler.Instance.Highlight(newRow, newCol);
                newRow += direction[i, 0];
                newCol += direction[i, 1];
            }
        }
    }
}
