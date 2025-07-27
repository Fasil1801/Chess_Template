using Chess.Scripts.Core;
using UnityEngine;

public abstract class ChessPiece : MonoBehaviour
{
    protected int row;
    protected int col;
    public bool isWhite;

    private void Start()
    {
        ChessPlayerPlacementHandler Handiler = GetComponent<ChessPlayerPlacementHandler>();
        row = Handiler.row;
        col = Handiler.column;
    }
    private void OnMouseDown()
    {
        ChessBoardPlacementHandler.Instance.ClearHighlights();
        ShowLeagalMoves();
    }
    public abstract void ShowLeagalMoves();
    public bool IsValid(int row, int col) => row >= 0 && row < 8 && col >= 0 && col < 8;
}
