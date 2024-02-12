﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace Services.Aid.Models
{
    public class HumaneAid
    {
        [BsonId] // MongoDB tarafında ID olarak algılanması için gerekli.
        [BsonRepresentation(BsonType.ObjectId)] // ID'nin tipi için gerekli. (string)
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string LocationUrl { get; set; }
        public string HelpType { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public bool Status { get; set; }
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedTime { get; set; }
    }
}
