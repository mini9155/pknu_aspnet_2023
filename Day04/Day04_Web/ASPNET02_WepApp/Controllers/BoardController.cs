using ASPNET02_WepApp.Data;
using ASPNET02_WepApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET02_WepApp.Controllers
{
    public class BoardController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BoardController(ApplicationDbContext db)
        {
            _db = db; // 알아서 DB가 연결
        }
        public IActionResult Index()
        {
            IEnumerable<Board> objBoardList = _db.Boards.ToList();
            return View(objBoardList);
        }

        //https://localhost:7292/Board/Create
        public IActionResult Create()
        {
        return View();
        }
    }
}
