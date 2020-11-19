using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Application.Services.Books.Dtos;

namespace WebAPI.Application.Services.Books
{
    public interface IBookAccountingService
    {
        Task<IEnumerable<BookDto>> FindAll();
        Task<BookDto> FindById(int bookId);
    }
}