using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using MyProject.PolesManagement.Poles;

namespace MyProject.PolesManagement.Lines
{
    [Table("Lines")]
    public class Line : Entity<Guid>, IFullAudited, IPassivable
    {
        public virtual string Code { get; set; }
        [ForeignKey("BeginPoleId")]
        public virtual Pole BeginPole { get; set; }
        [Required]
        public virtual Guid? BeginPoleId { get; set; }
        [ForeignKey("EndPoleId")]
        public virtual Pole EndPole { get; set; }
        public virtual Guid? EndPoleId { get; set; }
        [Required]
        public virtual string Description { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual DateTime? DeletionTime { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual DateTime? LastModificationTime { get; set; }
        public virtual long? CreatorUserId { get; set; }
        public virtual long? DeleterUserId { get; set; }
        public virtual long? LastModifierUserId { get; set; }
        public virtual bool IsActive { get; set; }

        public Line()
        {
            CreationTime = Clock.Now;
            IsActive = true;
        }
    }

}
