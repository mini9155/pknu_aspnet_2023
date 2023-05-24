using aspnet02_boardapp.Data;
using aspnet02_boardapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet02_boardapp.Controllers
{
    // https://localhost:7181/Board/Index
    public class BoardController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BoardController(ApplicationDbContext db)
        {
            _db = db; // 알아서 DB가 연결
        }

        public IActionResult Index() // 게시판 최초화면 리스트
        {
            IEnumerable<Board> objBoardList = _db.Boards.ToList(); // SELECT쿼리
            return View(objBoardList);
        }

        // https://localhost:7181/Board/Create
        // GetMethod로 화면을 URL로 부를때 액션

        [HttpGet]
        public IActionResult Create() // 게시판 글쓰기
        {
            return View();
        }

        // Submit이 발생해서 내부로 데이터를 전달 액션

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Board board)
        {
            IEnumerable<Board> objBoardList = _db.Boards.ToList();      // SELECT 쿼리

            _db.Boards.Add(board); // INSERT
            _db.SaveChanges(); // COMMIT

            return RedirectToAction("Index", "Board");

            // WYSWYG
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var noteFromDb = _db.Boards.Find(Id);
            //var noteFromDbFirst = _db.Notes.FirstOrDefault(u => u.Id == Id);
            //var noteFromDbSingle = _db.Notes.SingleOrDefault(u => u.Id == Id);

            if (noteFromDb == null)
            {
                return NotFound();
            }

            return View(noteFromDb);
        }

        // GET
        // Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Board board)
        {
            board.PostDate = DateTime.Now;
            _db.Boards.Update(board);
            _db.SaveChanges();

            return RedirectToAction("Index", "Board");
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var noteFromDb = _db.Boards.Find(Id);
            //var noteFromDbFirst = _db.Notes.FirstOrDefault(u => u.Id == Id);
            //var noteFromDbSingle = _db.Notes.SingleOrDefault(u => u.Id == Id);

            if (noteFromDb == null)
            {
                return NotFound();
            }

            return View(noteFromDb);
        }

        // Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? Id)
        {
            var board = _db.Boards.Find(Id);
            if (board == null)
            {
                return NotFound();
            }

            _db.Boards.Remove(board); // 쿼리 삭제
            _db.SaveChanges();

            return RedirectToAction("Index", "Board");
        }

        public IActionResult Details(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var noteFromDb = _db.Boards.Find(Id);
            //var noteFromDbFirst = _db.Notes.FirstOrDefault(u => u.Id == Id);
            //var noteFromDbSingle = _db.Notes.SingleOrDefault(u => u.Id == Id);

            if (noteFromDb == null)
            {
                return NotFound();
            }

            return View(noteFromDb);
        }
    }
}
