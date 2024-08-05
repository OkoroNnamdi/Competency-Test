using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Oriented_Database.Models
{
    public  class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId  CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; } = string.Empty;
    }
}
