using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaskapaiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaskapaiController : ControllerBase
    {

        private readonly MaskapaiDbContext _context;
        public MaskapaiController(MaskapaiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Maskapai>> GetMaskapais()
        {
            return _context.Maskapais.ToList();
        }

        // GET: api/Maskapai/1
        [HttpGet("{id}")]
        public ActionResult<Maskapai> GetMaskapai(int id)
        {
            var Maskapai = _context.Maskapais.Find(id);
            if (Maskapai == null)
            {
                return NotFound();
            }
            return Maskapai;
        }

        // POST: api/Maskapai
        [HttpPost]
        public ActionResult<Maskapai> CreateMaskapai(Maskapai Maskapai)
        {
            if (Maskapai == null)
            {
                return BadRequest();
            }
            _context.Maskapais.Add(Maskapai);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMaskapai), new { id = Maskapai.ID }, Maskapai);
        }


    }
}
