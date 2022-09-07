using OnlineForm.Domain.Entities;
using OnlineForm.Domain.Repositories;
using OnlineForm.Service.Interfaces;
using OnlineForm.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineForm.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task InsertAsync(UserDto userDto, string destinationFolder)
        {
            var user = new User { FirstName = userDto.FirstName, LastName = userDto.LastName };
            await _userRepository.InsertAsync(user, destinationFolder);
        }
    }
}
