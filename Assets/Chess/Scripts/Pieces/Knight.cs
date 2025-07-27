
public class Knight : ChessPiece
{
    public override void ShowLeagalMoves()
    {
        int[,] direction = new int[,]
         {
           {-2,-1},{-2,1},{-1,-2},{-1,2},{1,-2},{1,2},{2,-1},{2,1}
         };

        for (int i = 0; i < 8; i++)
        {
            int newRow = row + direction[i, 0];
            int newCol = col + direction[i, 1];
            if (IsValid(newRow, newCol))
            {
                ChessBoardPlacementHandler.Instance.Highlight(newRow, newCol);
            }
        }
    }
}
