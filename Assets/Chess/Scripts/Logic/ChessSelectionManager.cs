using UnityEngine;

public class ChessSelectionManager : MonoBehaviour
{
    public static ChessSelectionManager instance;

    private ChessPiece[,] board = new ChessPiece[8, 8];
    private void Awake()
    {
        instance = this;
    }
    public void AddToBoard(ChessPiece piece, int row, int col)
    {
        board[row, col] = piece;
    }

    public ChessPiece GetPiece(int row, int col)
    {
        if (!board[row, col]) return null;
        return board[row, col];
    }
}
