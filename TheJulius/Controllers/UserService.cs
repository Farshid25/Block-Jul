using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Julius.Data;
using Julius.Models;
using TheJulius.Model;

namespace Julius.Controllers
{
    public class UserService
    {
        UserContext _userContext = new UserContext();         

        public UserService() { 
        }

        public void AddUser(User user) {
            //user = new Patient(user.Name,  user.Role);
            _userContext.UsersCollection.InsertOne(user);
           // user.ToString();
        }

        public void AddPatient(User user) {
            _userContext.UsersCollection.InsertOne(user);
        }
        
        public async Task<UpdateResult> UpdateUser(string id, UserEnum role) {
            var filter = Builders<User>.Filter.Eq(s => s.Id, id);
            var update = Builders<User>.Update
                .Set(s => s.Role, role);
            return await _userContext.UsersCollection.
               UpdateOneAsync(filter, update);             
        }
        //public async Task<ReplaceOneResult> UpdateUserBody(string id, string rol) {
        //    var item = new User { Role = rol };

        //    return await UpdateUser(id, item);
        //}

        public async Task<DeleteResult> DeleteUser(string id) {             
            return await _userContext.UsersCollection
                .DeleteOneAsync(a=> a.Id == id);              
        }

        public async Task<User> SelectUser(string id) {       
            return await _userContext.UsersCollection
                .Find(a => a.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<User>> SelectAllUsers() {
            return await _userContext.UsersCollection
                .Find(_ => true).ToListAsync();
        }
    }
}
