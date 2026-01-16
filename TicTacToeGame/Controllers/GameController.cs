using Microsoft.AspNetCore.Mvc;
using TicTacToeGame.Services;

namespace TicTacToeGame.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        public IActionResult Index(bool vsComputer = false)
        {
            var game = _gameService.GetGame(vsComputer);
            return View(game);
        }

        public IActionResult Move(int index)
        {
            _gameService.MakeMove(index);
            return RedirectToAction("Index");
        }

        public IActionResult Reset()
        {
            _gameService.ResetGame();
            return RedirectToAction("Index");
        }
    }
}
