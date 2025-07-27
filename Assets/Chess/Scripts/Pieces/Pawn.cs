
using UnityEditorInternal;
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
        HighlightEnemy(row + direction, col+1);
        HighlightEnemy(row + direction, col-1);
    }

    private void HighlightMoves(int row, int col)
    {
        if (IsValid(row, col))
        {
            var piece = ChessSelectionManager.instance.GetPiece(row, col);
            if (piece != null) return;

            ChessBoardPlacementHandler.Instance.Highlight(row, col);
        }
    }
    private void HighlightEnemy(int row, int col)
    {
        if (IsValid(row,col))
        {
            var piece = ChessSelectionManager.instance.GetPiece(row, col);
            if (piece != null && !piece.isWhite == this.isWhite)
            {
                ChessBoardPlacementHandler.Instance.HighlightEnemy(row, col);
            }
        }
    }
}
