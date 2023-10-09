using GemBookStore.Models.Domain;
using GemBookStore.Models.DTO;
using GemBookStore.Repositories.Abstract;

namespace GemBookStore.Repositories.Implementation
{
    public class BookService : IBookService
    {
        private readonly DataBaseContext context;

        public BookService(DataBaseContext context)
        {
            this.context = context;
        }

        public bool Add(Book model)
        {
            try
            {
                context.Books.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.FindById(id);
                if (data == null)
                    return false;
                context.Books.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Book FindById(int id)
        {
            return context.Books.Find(id);
        }

        public IEnumerable<Book> GetAll()
        {
            var data = (from book in context.Books join author in context.Author
                        on book.AuthorId equals author.Id
                        join publisher in context.Publisher on book.PublisherId equals publisher.Id
                        join genre in context.Genre on book.GenreId equals genre.Id
                        select new Book
                        {
                            Id = book.Id,
                            AuthorId = book.AuthorId,
                            GenreId= book.GenreId, 
                            Isbn=book.Isbn,
                            PublisherId=book.PublisherId,
                            Title=book.Title,
                            TotalPages=book.TotalPages, 
                            GenreName=genre.Name,
                            AuthorName=author.AuthorName,
                            PublisherName=publisher.PublisherName
                        }).ToList();
            return data;

        }

        public bool Update(Book model)
        {
            try
            {
                context.Books.Update(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
