
namespace lubee_web_api.Controllers
{
    [ApiController]
    [Route("api/contratos")]
    public class ContratoByIdController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContratoByIdController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<Contrato> GetContratoById(int id)
        {
            var contrato = _context.Contratos.FirstOrDefault(c => c.Id == id);

            if (contrato == null)
            {
                return NotFound();
            }

            return contrato;
        }
    }
}
