
namespace lubee_web_api.Controllers
{
    [ApiController]
    [Route("api/contratos")]
    public class ContratoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContratoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Contrato> GetAllContratos()
        {
            return _context.Contratos.ToList();
        }
    }

}
