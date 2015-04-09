using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace DSystems.Domain
{
    public class User : Entity, IHasCreationTime, IPassivable, Abp.Domain.Entities.Auditing.IFullAudited
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
