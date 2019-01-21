using Books.Api.Entities;
 using Books.Api.ExternalModels;
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks;
 
 namespace Books.Api.Services
 {
     public interface IBooksRepository
     {
         Task<Book> GetBookAsync(Guid id);
 
         void AddBook(Book bookToAdd);
 
         Task<bool> SaveChangesAsync();
 
         Task<IEnumerable<BookCover>> GetBookCoversAsync(Guid bookId);
     }
 }