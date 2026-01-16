using System.Text.Json;
using TicTacToeGame.Models;

namespace TicTacToeGame.Services
{
    public interface IGameService
    {
        GameState GetGame(bool vsComputer);
        void MakeMove(int index);
        void ResetGame();
    }
}

