using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Application.Services.Books.Dtos;

namespace WebAPI.Application.Services.Books.Impls
{
    public class FakeInMemoryBookAccountingService : IBookAccountingService
    {
        private List<BookDto> FakeBooks;

        public FakeInMemoryBookAccountingService()
        {
            FakeBooks = new List<BookDto>(new BookDto[]
            {
                new BookDto()
                {
                    Id = 1,
                    Name = "Domain-Driven Design",
                    Author = "Eric Evans",
                    PublishingYear = 2017
                },
                new BookDto()
                {
                    Id = 2,
                    Name = "Introduction to Algorithms",
                    Author = "Tomas Cormen",
                    PublishingYear = 2013
                },
                new BookDto()
                {
                    Id = 3,
                    Name = "Elegant Objects",
                    Author = "Egor Bugaenko",
                    PublishingYear = 2014
                }
            });
        }
        
        public Task<IEnumerable<BookDto>> FindAll()
        {
            return Task.FromResult<IEnumerable<BookDto>>(FakeBooks);
        }

        public Task<BookDto> FindById(int bookId)
        {
            return Task.FromResult(FakeBooks.Find(fakeBook => fakeBook.Id == bookId));
        }
    }
}