using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelationsNaN.Data;

namespace RelationsNaN.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly RelationsNaNContext _context;

        public PurchasesController(RelationsNaNContext context)
        {
            _context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index()
        {
            var relationsNaNContext = _context.Purchase.Include(p => p.GamePurchases).ThenInclude(gp => gp.Game);
            return View(await relationsNaNContext.ToListAsync());
        }
    }
}