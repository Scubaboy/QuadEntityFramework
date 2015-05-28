using System;
using System.ComponentModel.DataAnnotations;

namespace QuadEntityFramework.Entities
{
    /// <summary>
    /// Class defines the structure of a DB update tracking entity.
    /// </summary>
    public class UpdateTrackerEntity
    {
        [Key]
        public virtual int ID { get; set; }

        [Required]
        public virtual DbUpdate UpdateMade { get; set; }

        [Required]
        public virtual string MadeBy { get; set; }

        [Required]
        public virtual DateTime TimeStamp { get; set; }
    }
}
