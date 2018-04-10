using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
 
using Julius.Data;
using Julius.Models;

namespace Julius.Controllers
{
    public class UserService
    {
        UserContext _userContext; //= new ObjectContext();

        public UserService() {
            _userContext = new UserContext();
        }

        public void AddBook(User user) {
            _userContext.UsersCollection.InsertOne(user);
        }

        public async Task<User> SelectBook(string id) {
            var filter = Builders<User>.Filter.Eq("Id", id);

            return await _userContext.UsersCollection
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<User>> SelectAllBooks() {
            return await _userContext.UsersCollection
                .Find(_ => true).ToListAsync();
        }

    }
}
