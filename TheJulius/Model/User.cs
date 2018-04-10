using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Julius.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        //public ObjectId Id { get; set; }  
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
       
 
    }
}
                        
 
