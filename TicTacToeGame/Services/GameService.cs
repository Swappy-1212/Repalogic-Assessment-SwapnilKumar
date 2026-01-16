using TicTacToeGame.Helper;
using TicTacToeGame.Models;

namespace TicTacToeGame.Services
{
    public class GameService : IGameService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string SessionKey = "GameState";

        private ISession Session =>
            _httpContextAccessor.HttpContext!.Session;

        public GameService(IHttpContextAccessor accessor)
        {
            _httpContextAccessor = accessor;
        }

        public GameState GetGame(bool vsComputer)
        {
            var game = Session.GetObject<GameState>(SessionKey)
                       ?? new GameState { VsComputer = vsComputer };

            Session.SetObject(SessionKey, game);
            return game;
        }

        public void MakeMove(int index)
        {
            var game = Session.GetObject<GameState>(SessionKey);
            if (game == null || game.Winner != null) return;

            if (string.IsNullOrEmpty(game.Board[index]))
            {
                game.Board[index] = game.XTurn ? "X" : "O";
                game.XTurn = !game.XTurn;
                game.Winner = CheckWinner(game.Board);

                if (game.VsComputer && !game.XTurn && game.Winner == null)
                {
                    ComputerMove(game);
                }
            }

            Session.SetObject(SessionKey, game);
        }

        public void ResetGame()
        {
            Session.Remove(SessionKey);
        }

        private void ComputerMove(GameState game)
        {
            for (int i = 0; i < 9; i++)
            {
                if (string.IsNullOrEmpty(game.Board[i]))
                {
                    game.Board[i] = "O";
                    game.XTurn = true;
                    game.Winner = CheckWinner(game.Board);
                    break;
                }
            }
        }

        private string? CheckWinner(string[] board)
        {
            int[,] wins =
            {
                {0,1,2},{3,4,5},{6,7,8},
                {0,3,6},{1,4,7},{2,5,8},
                {0,4,8},{2,4,6}
            };

            for (int i = 0; i < wins.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(board[wins[i, 0]]) &&
                    board[wins[i, 0]] == board[wins[i, 1]] &&
                    board[wins[i, 1]] == board[wins[i, 2]])
                {
                    return board[wins[i, 0]];
                }
            }

            return board.All(b => !string.IsNullOrEmpty(b)) ? "Draw" : null;
        }
    }
}
