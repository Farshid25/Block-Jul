using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using TheJulius.Model;

namespace Julius.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]  
        public string Id { get; set; }
        public string Name { get; set; }
        //public string LastName { get;  set; }
        public UserEnum Role { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; }
        

        public User(string name, UserEnum role) {
            this.Name = name;
            this.Role = role;
        }

        public override string ToString() {
            var x = this.GetType().ToString();
            return "name: " + Name + "Role: "+Role+  " type: " + x;
        }
    }
    
}
 
