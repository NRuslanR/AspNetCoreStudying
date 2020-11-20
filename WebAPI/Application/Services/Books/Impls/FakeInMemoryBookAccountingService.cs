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
        
        public async Task<IEnumerable<BookDto>> FindAll()
        {
            return FakeBooks;
        }

        public async Task<BookDto> FindById(int bookId)
        {
            return FakeBooks.Find(fakeBook => fakeBook.Id == bookId);
        }

        public async Task<BookDto> AddBook(BookDto newBookDto)
        {
            newBookDto.Id = FakeBooks.Count + 1;
            
            FakeBooks.Add(newBookDto);

            return newBookDto;
        }

        public async Task UpdateBook(BookDto bookDto)
        {
            BookDto oldBookDto = await FindById(bookDto.Id);
            
            if (oldBookDto is null)
                throw new BookNotFoundException($"Book with id = {bookDto.Id} not found for update");

            FakeBooks[FakeBooks.IndexOf(oldBookDto)] = bookDto;
        }

        public async Task RemoveBook(int bookId)
        {
            BookDto removeableBookDto = await FindById(bookId);
            
            if (removeableBookDto is null)
                throw new BookNotFoundException($"Book with id = {bookId} not found for remove");

            FakeBooks.Remove(removeableBookDto);
        }
    }
}