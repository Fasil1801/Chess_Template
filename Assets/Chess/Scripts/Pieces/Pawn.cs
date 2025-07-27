
using UnityEngine;

public class Pawn : ChessPiece
{
    public override void ShowLeagalMoves()
    {
        int direction = isWhite ? -1 : 1;
        int startRow = isWhite ? 6 : 1;
        HighlightMoves(row + direction, col);
        if (row == startRow)
        {
            HighlightMoves(row + 2 * direction, col);
        }
        HighlightMoves(row + direction, col+1);
        HighlightMoves(row + direction, col-1);
    }

    private void HighlightMoves(int row, int col)
    {
        if (IsValid(row, col))
        {
            ChessBoardPlacementHandler.Instance.Highlight(row, col);
        }
    }
}
