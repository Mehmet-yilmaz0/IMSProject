using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartCourseSelectorWeb.Models;



namespace SmartCourseSelectorWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranscriptsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public TranscriptsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Transcripts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transcript>>> GetTranscripts()
        {
            return await _context.Transcripts.ToListAsync();
        }

        // GET: api/Transcripts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transcript>> GetTranscripts(int id)
        {
            var transcripts = await _context.Transcripts.FindAsync(id);

            if (transcripts == null)
            {
                return NotFound();
            }

            return transcripts;
        }
    }
}
