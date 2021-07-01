using System.Collections.Generic;

namespace UserTicketService
{
    public interface IBookRepository
    {
        IEnumerable<Book> FindAll();
    }
}
