using Microsoft.EntityFrameworkCore;
using SmartCourseSelectorWeb.Models;

namespace SmartCourseSelectorWeb.Controllers
{
    public class QuotasController
    {
        private readonly ApplicationDbContext _context;

        public QuotasController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
