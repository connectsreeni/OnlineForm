using OnlineForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineForm.Domain.Repositories
{
    public interface IUserRepository
    {
        Task InsertAsync(User user, string destinationFolder);
    }
}
