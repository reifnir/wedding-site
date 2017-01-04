using System.Security;

namespace maryplusjim.ui.Db
{
    public class DbConfig
    {
        public DbConfig()
        {
        }
        /*
        private static readonly string Endpoint = "";
        private static readonly string Key = "";
        private static readonly string DatabaseId = "";
        private static readonly string CollectionId = "";

             
             */

        public string CollectionId { get; set; }
        public string DatabaseId { get; set; }
        public string Endpoint { get; set; }
        public string Key { get; set; }
    }
}