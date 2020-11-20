using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Application.Services.Books.Dtos;

namespace WebAPI.Application.Services.Books
{
    public class BookAccountingServiceException : Exception
    {
        public BookAccountingServiceException(string message) : base(message)
        {
            
        }
    }

    public class BookNotFoundException : BookAccountingServiceException
    {
        public BookNotFoundException(string message) : base(message)
        {
            
        }
        
    }
    
    public interface IBookAccountingService
    {
        Task<IEnumerable<BookDto>> FindAll();
        Task<BookDto> FindById(int bookId);
        Task<BookDto> AddBook(BookDto newBookDto);
        Task UpdateBook(BookDto bookDto);
        Task RemoveBook(int bookId);
    }
}