using System.Text.Json.Serialization;
using System.Text.Json;

namespace lubee_web_api.Controllers
{
    [ApiController]
    [Route("api/cursos")]
    public class CursoByIdController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public CursoByIdController(ApplicationDbContext context)
        {
            _context = context;

            // Configurar JsonSerializerOptions para preservar referencias circulares
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetCursoById(int id)
        {
            var curso = _context.Cursos
                .Include(c => c.Contrato)
                .Include(c => c.Producto)
                .FirstOrDefault(c => c.Id == id);

            if (curso == null)
            {
                return NotFound();
            }

            // Serializar el objeto usando JsonSerializerOptions
            var cursoJson = JsonSerializer.Serialize(curso, _jsonSerializerOptions);

            return cursoJson;
        }
    }
}
