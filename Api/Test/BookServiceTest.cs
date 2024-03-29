using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Library_Api.Contexts;
using Library_Api.Entities;
using Library_Api.Interfaces;
using Library_Api.Services;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace Test
{
    public class BookServiceTest
    {
        private Mock<DbSet<Book>> _dbSet;
        private Mock<LibraryContext> _mockContext;
        private IBookService _service;

        [SetUp]
        public void Setup()
        {
            var sampleData = new List<Book>
            {
                // Initialize my test data
                new Book { BookId = 1,
                    Name = "Gulliver's Travels",
                    YearLauch = "1726",
                    Edition = 1,
                    PublishingCompany = "Pearson English",
                    UrlWebImg = "https://m.media-amazon.com/images/I/51W6w1PrkbL._SX384_BO1,204,203,200_.jpg",
                    Price = 59M, Author = new Author { AuthorId = 1,
                    Name = "Jonathan Swift" } }
                
            }.AsQueryable();

            _dbSet = new Mock<DbSet<Book>>();
            var asyncEnumerable = new TestAsyncEnumerable<Book>(sampleData);
            _dbSet.As<IAsyncEnumerable<Book>>().Setup(m => m.GetAsyncEnumerator(default)).Returns(asyncEnumerable.GetAsyncEnumerator(default));
            _dbSet.As<IQueryable<Book>>().Setup(x => x.Provider).Returns(new TestAsyncQueryProvider<Book>(sampleData.AsQueryable().Provider));
            _dbSet.As<IQueryable<Book>>().Setup(x => x.Expression).Returns(sampleData.AsQueryable().Expression);
            _dbSet.As<IQueryable<Book>>().Setup(x => x.ElementType).Returns(sampleData.AsQueryable().ElementType);
            _dbSet.As<IQueryable<Book>>().Setup(x => x.GetEnumerator()).Returns(sampleData.GetEnumerator());

            _mockContext = new Mock<LibraryContext>();
            _mockContext.Setup(c => c.Books).Returns(_dbSet.Object);

            _service = new BookService(_mockContext.Object);
        }

        [Test]
        public async Task Test1AsyncGetBooksAsync_Should_Return_Total_Books()
        {
            var result = await _service.Get_Books();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }

        [Test]
        public async Task Test2AsyncGet_BookById_Should_Return_A_Book_By_Id()
        {
            var result = await _service.Get_BookById(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.BookId);
        }

        [Test]
        public async Task Test3AsyncGet_BookByName_Should_Return_A_Book_By_Name()
        {
            var result = await _service.Get_BookByName("Gulliver's Travels") as List<Book>;

            Assert.IsNotNull(result);
            Assert.AreEqual("Gulliver's Travels", result[0].Name);
        }

        [Test]
        public async Task Test4AsyncPost_CreateBook_Should_AddAsync_Entity_To_DbContext()
        {
            var entity = new Book { BookId = 2,
                                    Name = "it a coisa",
                                    YearLauch = "2014",
                                    Edition = 1,
                                    PublishingCompany = "Suma",
                                    UrlWebImg = "https://m.media-amazon.com/images/I/51z0s3GcvwL._SY344_BO1,204,203,200_QL70_ML2_.jpg",
                                    Price = 45M,
                                    Author = new Author { AuthorId = 2,
                                    Name = "Stephen King" } };

            await _service.Post_CreateBook(entity);

            _dbSet.Verify(m => m.AddAsync(entity, It.IsAny<CancellationToken>()), Times.Once);
            _mockContext.Verify(db => db.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        [Test]
        public async Task Test5AsyncDelete_Book_Should_Return_Delete_Entity()
        {
            var entity = await _service.Get_BookById(1);
            await _service.Delete_Book(entity);

            _dbSet.Verify(m => m.Remove(It.IsNotIn<Book>()), Times.Once);
            _mockContext.Verify(m => m.SaveChangesAsync(default), Times.Once);
        }
    }
}