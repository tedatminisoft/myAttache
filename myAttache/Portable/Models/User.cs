using System;
namespace myAttache.Portable.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class User
    {
        public Guid id { get; set; }
        public string type { get; set; }
        public long arcsId { get; set; }
        public string attorneyId { get; set; }
        public string name { get; set; }
        public string nickName { get; set; }
        public bool isARUser { get; set; }
        public bool isWipUser { get; set; }
        public string title { get; set; }
        public string email { get; set; }
        public string location { get; set; }
        public string department { get; set; }
        public string firmId { get; set; }
        public string databaseId { get; set; }
        public string databaseName { get; set; }
        public bool isActive { get; set; }
        public List<Object> alerts { get; set; }

    }
}
