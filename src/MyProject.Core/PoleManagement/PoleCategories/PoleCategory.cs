using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using MyProject.PolesManagement;

namespace MyProject.PolesManagement.PoleCategories
{
    [Table("PoleCategories")]
    public class PoleCategory : Entity<Guid>, IFullAudited, IPassivable
    {
        public virtual string Code { get; set; }
        [Required]
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual DateTime? DeletionTime { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual DateTime? LastModificationTime { get; set; }
        public virtual long? CreatorUserId { get; set; }
        public virtual long? DeleterUserId { get; set; }
        public virtual long? LastModifierUserId { get; set; }
        public virtual bool IsActive { get; set; }

        public PoleCategory()
        {
            CreationTime = Clock.Now;
            IsActive = true;
        }
    }
}
