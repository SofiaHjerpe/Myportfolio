using MongoDB.Driver;
using MyPortfolio.Models;
using System;

namespace MyPortfolio
{
    public class Database
    {
        MongoClient dbClient = new MongoClient();

        private IMongoDatabase GetDb()
        {
            return  dbClient.GetDatabase("MyportfolioDB");
           
        }

        public async Task<List<Project>> GetProjectsAsync()
        {
           return await GetDb().GetCollection<Project>("Projects")
                .Find(p => true)
                .ToListAsync();
        }
        
        public async Task SaveProject (Project project)
        {
        await    GetDb().GetCollection<Project>("Projects")
                .InsertOneAsync(project);
        }
        
    }
}
