using MongoDB.Driver;
using Integrador.Models;

namespace Integrador.Models
{
    public class ContextMongoDB
    {
        public static string ConnectionString { get; set; }
        public static string DatabaseName { get; set; }
        public static bool IsSSL { get; set; }

        private IMongoDatabase _database { get; set; }

        public ContextMongoDB()
        {
            try
            {
                MongoClientSettings settings = MongoClientSettings.
                    FromUrl(new MongoUrl(ConnectionString));

                if (IsSSL)
                {
                    settings.SslSettings = new SslSettings
                    {
                        EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
                    };
                }

                var mongoClient = new MongoClient(settings);
                _database = mongoClient.GetDatabase(DatabaseName);
            }
            catch (Exception)
            {

                throw new Exception("It was not possible to connect");
            }
        }

        //public IMongoCollection<User> User
        //{
        //    get
        //    {
        //        return _database.GetCollection<User>("users");
        //    }
        //}
        public IMongoCollection<User> User => _database.GetCollection<User>("users");
    }
}
