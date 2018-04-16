using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Julius.Data;
using Julius.Models;

namespace Julius.Controllers
{
    public class UserService
    {
        UserContext _userContext = new UserContext();

        public UserService() {
 
        }

        public void AddBook(User user) {
            _userContext.UsersCollection.InsertOne(user);
        }

        public async Task<UpdateResult> Put(string id, int age) {
            var filter = Builders<User>.Filter.Eq(s => s.Id, id);
            var update = Builders<User>.Update
                .Set(s => s.Age, age);
            return await _userContext.UsersCollection.
               UpdateOneAsync(filter, update);             
        }

        public async Task<DeleteResult> DeleteUser(string id) {
            
            return await _userContext.UsersCollection
                .DeleteOneAsync(a=> a.Id == id);              
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
