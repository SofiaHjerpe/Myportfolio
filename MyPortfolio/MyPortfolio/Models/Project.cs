using MongoDB.Bson;

namespace MyPortfolio.Models
{
    public class Project
    {
        public ObjectId Id { get; set; }
        public string Namn { get; set; }
        public string Description { get; set; } 
        public string Link { get; set; } 
        
        public string Programming { get; set; }    
    }
}
