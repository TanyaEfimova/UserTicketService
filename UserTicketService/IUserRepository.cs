using System.Collections.Generic;

namespace UserTicketService
{
    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
    }
}
