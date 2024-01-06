using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Writer.Api.Repositories;

namespace Writer.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class WritersController : ControllerBase
    {
        private readonly IWriterRepository _writerRepository;

        public WritersController(IWriterRepository writerRepository)
        {
            _writerRepository = writerRepository;
        }

        [HttpGet]
        public ActionResult<List<Models.Writer>> Get()
        {
            return _writerRepository.GetAll();
        }

        [HttpGet("{Id:int}")]
        public ActionResult<Models.Writer> Get(int Id)
        {
            return _writerRepository.Get(Id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Models.Writer writer)
        {
            var result = _writerRepository.Insert(writer);
            return Created($"/get/{result.Id}", result);
        }
    }
}
