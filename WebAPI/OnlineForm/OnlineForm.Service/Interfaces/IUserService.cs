using OnlineForm.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineForm.Service.Interfaces
{
    public interface IUserService
    {
        Task InsertAsync(UserDto userDto, string destinationFolder);
    }
}
