using System;

namespace PG.Core.Models.UserEntities
{
    public class UserEntity
    {
        public UserEntity(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        protected UserEntity() { }
        
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
