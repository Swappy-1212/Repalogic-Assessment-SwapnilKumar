namespace TicTacToeGame.Models
{
    public class GameState
    {
        public string[] Board { get; set; } = new string[9];
        public bool XTurn { get; set; } = true;
        public bool VsComputer { get; set; }
        public string? Winner { get; set; }
    }
}
