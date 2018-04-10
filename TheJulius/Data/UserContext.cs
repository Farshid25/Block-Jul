using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Julius.Models;

namespace Julius.Data
{
    public class UserContext
    {
        private readonly IMongoDatabase _database;

        public UserContext() {
            var settings = new Settings();
            try {
                var client = new MongoClient(settings.ConnectionString);
                _database = client.GetDatabase(settings.Database);
            }
            catch (Exception ex) {
                throw new Exception("Can not access to db server.", ex);
            }
        }

        public IMongoCollection<User> UsersCollection => _database.GetCollection<User>("Users");
        //public IMongoCollection<Member> MemberCollection => _database.GetCollection<Member>("Members");

        //public IMongoCollection<User> TestCollection => _database.GetCollection<User>("Tests");

    }
}
 