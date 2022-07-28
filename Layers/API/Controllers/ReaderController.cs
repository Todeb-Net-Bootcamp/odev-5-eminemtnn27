using Business.Abstract;
using DTO.Reader;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ReaderController : ControllerBase
    {
        private readonly IReaderService _service;
        public ReaderController(IReaderService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var data = _service.GetAll();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post(CreateReaderRequest Reader)
        {
            var response = _service.Insert(Reader);
            return Ok(response);
        }
        [HttpPut]
        public IActionResult Put(UpdateReaderRequest reader)
        {
            var response = _service.Update(reader);
            return Ok(response);
        }
        [HttpDelete]
        public IActionResult Delete(Reader Reader)
        {
            var response = _service.Delete(Reader);
            return Ok(response);
        }
    }
}
