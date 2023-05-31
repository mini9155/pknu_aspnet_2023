using BookReport.Data;
using BookReport.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookReport.Controllers
{
    public class StoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Story> objNoteList = _db.Stories.ToList();
            return View(objNoteList);
        }
    }
}
