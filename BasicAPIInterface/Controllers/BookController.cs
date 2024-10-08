using BasicAPIInterface.Domain.Models;
using BasicAPIInterface.Domain.Models.DTOs;
using BasicAPIInterface.Domain.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicAPIInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        
        
        // GET: api/<BookController>
        [HttpGet]
        public async Task<ActionResult<List<Book>>> Get()
        {
            var items = await _bookService.GetAll();
            if (items == null || items.Count == 0)
                return NotFound();
            return Ok(items);
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> Get(int id)
        {
            var item = await _bookService.GetById(id);
            if(item == null) 
                return NotFound();
            return Ok(item);
        }

        // POST api/<BookController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateBookRequest book)
        {
            var result = await _bookService.Create(book);
            if (result.ValidationErrors.Count > 0)
                return BadRequest(result.ValidationErrors);
            return Ok(result.Id);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
