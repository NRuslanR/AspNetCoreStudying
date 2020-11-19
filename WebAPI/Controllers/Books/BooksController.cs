using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAPI.Application.Services.Books;
using WebAPI.Application.Services.Books.Dtos;

namespace WebAPI
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookAccountingService _bookAccountingService;
        
        public BooksController(IBookAccountingService bookAccountingService)
        {
            _bookAccountingService = bookAccountingService;
        }
        
        [HttpGet]
        public async Task<IActionResult> BookList()
        {
            return Ok(await _bookAccountingService.FindAll());
        }
        
        [HttpGet]
        [Route("{bookId:int}")]
        public async Task<IActionResult> GetBook(int bookId)
        {
            if (!ModelState.IsValid)
                return BadRequest($"Book Id must have integer type");

            BookDto bookDto = await _bookAccountingService.FindById(bookId);

            if (bookDto is null)
                return NotFound($"Book with id = {bookId} not found");
            
            return Ok(bookDto);
        }
    }
}