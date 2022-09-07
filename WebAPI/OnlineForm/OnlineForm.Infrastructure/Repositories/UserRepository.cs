using Newtonsoft.Json;
using OnlineForm.Domain.Entities;
using OnlineForm.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineForm.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task InsertAsync(User user, string destinationFolder)
        {
                var json = JsonConvert.SerializeObject(user, Formatting.Indented);

                var file = destinationFolder + "/user-data.json";

                if (!File.Exists(file))
                {
                    var jsonFile = File.Create(file);
                    jsonFile.Close();
                }

            using StreamWriter streamWriter = File.AppendText(file);
            await streamWriter.WriteAsync(json);
        }
    }
}
